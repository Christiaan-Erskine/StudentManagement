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
    public partial class AddStudent : Form
    {
        private DataHandler dh = new DataHandler();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dh.InsertObject(
                    new Student(
                        nameTextBox.Text,
                        surnameTextBox.Text,
                        imageTextBox.Text,
                        dOBDateTimePicker.Value,
                        genderTextBox.Text,
                        phoneTextBox.Text,
                        addressTextBox.Text,
                        moduleCodeTextBox.Text
                    )
             );




            MessageBox.Show("Student Addedd successfully");

            MainStudent mainStudent = new MainStudent();
            mainStudent.Show();
            this.Close();

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            MainStudent mainStudent = new MainStudent();
            mainStudent.Show();
            this.Close();
        }
    }
}
