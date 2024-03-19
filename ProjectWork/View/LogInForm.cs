using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWork.View
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (Show.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text=="")
            {
                MessageBox.Show("User Name cannot be null");
            }
            else if(txtPassword.Text=="")
            {
                MessageBox.Show("Password Field Cannot be null");

            }
            else if(txtUserName.Text=="Admin" && txtPassword.Text=="1q2w3E*")
            {
                MessageBox.Show("Login Successful");
                Form1 fm=new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Is not correct try again");
            }
        }
    }
}
