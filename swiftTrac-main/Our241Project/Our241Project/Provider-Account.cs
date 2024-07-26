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
    public partial class Provider_Account : Form
    {
        public Provider_Account()
        {
            InitializeComponent();
        }
        Provider provider= new Provider();
       

        private void Provider_Account_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Provider_Account_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void Provider_Account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swiftTrackDataSet.provider' table. You can move, or remove it, as needed.
            this.providerTableAdapter.Fill(this.swiftTrackDataSet.provider);
           

        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string email,username,password; int phonenumber;
                if (emailTXT.Text != "")
                {
                    email = emailTXT.Text;
                    if(int.TryParse(providerphonenumberTXT.Text, out phonenumber))
                    {
                        if (usernameTXT.Text != "")
                        {
                            username = usernameTXT.Text;
                            if (passwordTXT.Text != "")
                            {
                                password = passwordTXT.Text;
                                if (confirmpasswordTXT.Text != "")
                                {
                                    if (confirmpasswordTXT.Text == password)
                                    {
                                      if(confirmationCHECKBOX.Checked)
                                        {
                                            SwiftTrackDataSet.providerRow row;
                                            row = swiftTrackDataSet.provider.NewproviderRow();
                                            row.Email = email;
                                            row.username = username;
                                            row.password = password;
                                            row.phoneNumber =phonenumber.ToString();
                                            swiftTrackDataSet.provider.Rows.Add(row);
                                            providerBindingSource.EndEdit();
                                            providerTableAdapter.Update(swiftTrackDataSet.provider);
                                            MessageBox.Show("You Have Successfully Signed In \n" +
                                                "Welcome To Swift Track ! ", "Successful Sign In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            ClearSignup();

                                        }
                                        else
                                        {
                                            MessageBox.Show("Confirm Your Information","Missing Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);                                
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Write The Same password", "Wrong password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        confirmpasswordTXT.Focus();
                                        confirmpasswordTXT.SelectAll();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Confirm your password", "Missing password Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    confirmpasswordTXT.Focus();
                                }
                                

                            }
                            else
                            {
                                MessageBox.Show("Write your password", "Missing password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                passwordTXT.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Write Your username", "username Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            usernameTXT.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid PhoneNumber Input", "Phone Number Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        providerphonenumberTXT.Focus();
                        providerphonenumberTXT.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Please Write Your Email","Missing Email",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTXT.Focus();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void confirmpasswordTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            confirmpasswordTXT.PasswordChar = '*';
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string username,password;
                if (loginnameTXT.Text != "")
                {
                    if (loginpasswordTXT.Text != "")
                    {
                        username=loginnameTXT.Text;
                        password=loginpasswordTXT.Text;
                        try
                        {
                         string response= providerTableAdapter.providerLogin( username,password).ToString();
                            MessageBox.Show("Welcome " + username, "Provider Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            provider.ShowDialog();                                                                   
                        }

                        catch
                        {
                            MessageBox.Show("Incorrect Username or Password Please Check and Try Again","Invalid Login",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Please Enter your Password", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loginpasswordTXT.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter your User name", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginnameTXT.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearSignup()
        {
            emailTXT.Clear();
            providerphonenumberTXT.Clear();
            usernameTXT.Clear(); passwordTXT.Clear();signUpShowPassword.Checked= false;
            confirmpasswordTXT.Clear();confirmationCHECKBOX.Checked = false;
        }
        private void ClearformControls()
        {
            emailTXT.Clear();
            providerphonenumberTXT.Clear();
            usernameTXT.Clear(); passwordTXT.Clear();loginnameTXT.Clear();loginpasswordTXT.Clear();
            confirmpasswordTXT.Clear(); confirmationCHECKBOX.Checked = false;signUpShowPassword.Checked = false;
            logInShowPassword.Checked = false;
        }

        private void Provider_Account_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearformControls();
        }

        private void Provider_Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void passwordTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            passwordTXT.PasswordChar = '*';
        }

        private void loginpasswordTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            loginpasswordTXT.PasswordChar = '*';
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(logInShowPassword.Checked) {
                loginpasswordTXT.PasswordChar = '\0';
            }
            else
            {
                loginpasswordTXT.PasswordChar = '*';

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void signUpShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (signUpShowPassword.Checked)
            {
                passwordTXT.PasswordChar = '\0';
                confirmpasswordTXT.PasswordChar = '\0';
            }
            else
            {
                passwordTXT.PasswordChar = '*';
                confirmpasswordTXT.PasswordChar = '*';

            }
        }
    }
}
