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
    public partial class DeleteStudents : Form
    {
        public DeleteStudents()
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

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManagementDataSet);

        }

        private void UpdateStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManagementDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentManagementDataSet.Student);
            // TODO: This line of code loads data into the 'studentManagementDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentManagementDataSet.Student);

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            MainStudent mainStudent = new MainStudent();
            mainStudent.Show();
            this.Close();
        }

        private void studentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentManagementDataSet);

        }
    }
}
