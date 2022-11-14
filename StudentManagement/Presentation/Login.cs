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
        public loginForm()
        {
            InitializeComponent();

            var dh = new DataHandler();

            //test if the database is connected
            //dh.Insert("LeaveType", new[] { (Field: "LeaveType", Value: "Sick Leave") });
            //MessageBox.Show(dh.RetrieveData("LeaveType").Rows[0][0].ToString());
        }
    }
}