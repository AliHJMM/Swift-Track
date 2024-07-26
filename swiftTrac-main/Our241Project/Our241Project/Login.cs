using Our241Project.SwiftTrackDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our241Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Administrator admin = new Administrator();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string username ="" ;
                string password ="" ;
                if (usernameTXT.Text != "")
                {
                    username = usernameTXT.Text;

                    if (passwordTXT.Text != "")
                    {
                        password = passwordTXT.Text;
                        try
                        {
                            string response = adminTableAdapter.Login(username, password).ToString();

                            switch (username)
                            {
                                case "msiddique": MessageBox.Show("Welcome Boss Dr.Siddique", "Admin Room", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                                case "mohamed": MessageBox.Show("Welcome Mohame Abdulkarim", "Admin Room", MessageBoxButtons.OK, MessageBoxIcon.Information); ; break;
                                case "ali": MessageBox.Show("Welcome Ali Hassan", "Admin Room", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                                case "habib": MessageBox.Show("Welcome Habib Mansoor", "Admin Room", MessageBoxButtons.OK, MessageBoxIcon.Information); ; break;

                            }
                            this.Close();
                            admin.ShowDialog();
                            usernameTXT.Clear();
                            passwordTXT.Clear();

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("User name or password incorrect \n (Please check the Readme file)", "WRONG info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                     
                    }
                    else
                    {
                        MessageBox.Show("Enter your Password", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        passwordTXT.Focus();

                    }
                }
                else
                {
                    MessageBox.Show("Enter the user name", "Missing username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameTXT.Focus();
                    
                }
                
               

            }
            catch(Exception error)
            {
                MessageBox.Show("Invalid username or Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            

        }

        private void Login_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Login_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void passwordTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            passwordTXT.PasswordChar = '*';
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                passwordTXT.PasswordChar = '\0';

            }
            else
            {
                passwordTXT.PasswordChar = '*';
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            usernameTXT.Text = string.Empty;
            passwordTXT.Text = string.Empty;
        }
    }
}
