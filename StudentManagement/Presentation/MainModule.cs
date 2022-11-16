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
    public partial class MainModule : Form
    {
        public MainModule()
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

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewModules viewModules = new ViewModules();
            viewModules.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateModule updateModule = new UpdateModule();
            updateModule.Show();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteModule deleteModule = new DeleteModule();
            deleteModule.Show();
            this.Close();
        }
    }
}
