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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            MainStudent mainStudent = new MainStudent();
            mainStudent.Show();
            this.Close();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            MainModule mainModule = new MainModule();
            mainModule.Show();
            this.Close();
        }
    }
}
