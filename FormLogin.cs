using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Earmark_BCP
{
    public partial class FormLogin : Form
    {
        bool loginResult = false;
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {

                loginResult = true;
                this.Close();
            }
            else {
                MessageBox.Show("User atau Password salah");
            }
            
        }
    }
}
