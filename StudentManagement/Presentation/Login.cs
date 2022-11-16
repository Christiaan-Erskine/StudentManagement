using StudentManagement.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class loginForm : Form
    {
        public static void enableDoubleBuff(Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }

        public loginForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            enableDoubleBuff(panel1);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                FileHandler fh = new FileHandler();

                List<String> users = fh.ReadList();

                if (users != null && users.Contains($"{txtUsername.Text},{txtPassword.Text}"))
                {
                    Presentation.MainMenu mainMenu = new Presentation.MainMenu();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user credentials, please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please check the form to ensure that you have filled in all the values", "Missing values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}