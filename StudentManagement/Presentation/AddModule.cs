using StudentManagement.Classes;
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
    public partial class AddModule : Form
    {
        private DataHandler dh = new DataHandler();
        public AddModule()
        {
            InitializeComponent();
        }

        private void AddModule_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            dh.InsertObject(
                    new Module(
                        moduleCodeTextBox.Text,
                        nameTextBox.Text,
                        descriptionTextBox.Text
                    )
             );




            MessageBox.Show("Module Addedd successfully");

            MainModule mainModule = new MainModule();
            mainModule.Show();
            this.Close();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            MainModule mainModule = new MainModule();
            mainModule.Show();
            this.Close();
        }
    }
}
