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
    public partial class SignUp : Form
    {
        public static void enableDoubleBuff(System.Windows.Forms.Control cont)
        {
            System.Reflection.PropertyInfo DemoProp = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            DemoProp.SetValue(cont, true, null);
        }
        public SignUp()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            enableDoubleBuff(panel1);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            loginForm loginForm = new loginForm();
            loginForm.Show();
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty && txtConfirmPass.Text != string.Empty)
            {
                if (txtConfirmPass.Text == txtPassword.Text)
                {
                    FileHandler fh = new FileHandler();

                    List<string> users = fh.ReadList();

                    foreach (String user in users)
                    {
                        if (user.Split(',')[0] == txtUsername.Text)
                        {
                            MessageBox.Show("Username already taken, please select an altenative", "Usename Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    fh.Write($"{txtUsername.Text},{txtPassword.Text}", true);

                    MessageBox.Show("Registration Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loginForm loginForm = new loginForm();
                    loginForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Passwords do not match", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please check the form to ensure that you have filled in all the values", "Missing values", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
