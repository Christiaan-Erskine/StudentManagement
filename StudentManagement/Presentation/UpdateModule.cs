using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.Presentation
{
    public partial class UpdateModule : Form
    {
        public UpdateModule()
        {
            InitializeComponent();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddModule addModule = new AddModule();
            addModule.Show();
            this.Close();
        }

        private void moduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManagementDataSet);

        }

        private void moduleBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.moduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManagementDataSet);

        }

        private void UpdateModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDataSet.Module' table. You can move, or remove it, as needed.
            this.moduleTableAdapter.Fill(this.studentManagementDataSet.Module);

        }
    }
}
