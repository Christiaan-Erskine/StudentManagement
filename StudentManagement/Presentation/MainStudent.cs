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
    public partial class MainStudent : Form
    {
        public MainStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewStudents viewStudents   = new ViewStudents();
            viewStudents.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateStudents updateStudents  = new UpdateStudents();
            updateStudents.Show();
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DeleteStudents deleteStudents = new DeleteStudents();
            deleteStudents.Show();
            this.Close();
        }
    }
}
