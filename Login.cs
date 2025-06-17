using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KickBlast
{
    public partial class LoginForm : Form
    {
      
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "123") 
            {
                Home_From A = new Home_From(txtUsername.Text);
                A.Show();
            }
            else if (txtUsername.Text == "Guest" && txtPassword.Text == "456")

            {
                Home_From B = new Home_From(txtUsername.Text);
                B.Show();

            }


        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }


        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            { 
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar= false;
            }
        }

        private void linkLabelForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
            

         