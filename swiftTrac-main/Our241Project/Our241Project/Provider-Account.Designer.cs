namespace Our241Project
{
    partial class Provider_Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.signUpShowPassword = new System.Windows.Forms.CheckBox();
            this.confirmationCHECKBOX = new System.Windows.Forms.CheckBox();
            this.signupBTN = new System.Windows.Forms.Button();
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.confirmpasswordTXT = new System.Windows.Forms.TextBox();
            this.providerphonenumberTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logInShowPassword = new System.Windows.Forms.CheckBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.loginnameTXT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.loginpasswordTXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.providerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(545, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Create a New Account";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.signUpShowPassword);
            this.groupBox1.Controls.Add(this.confirmationCHECKBOX);
            this.groupBox1.Controls.Add(this.signupBTN);
            this.groupBox1.Controls.Add(this.usernameTXT);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.passwordTXT);
            this.groupBox1.Controls.Add(this.confirmpasswordTXT);
            this.groupBox1.Controls.Add(this.providerphonenumberTXT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.emailTXT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(550, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(395, 440);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign UP";
            // 
            // signUpShowPassword
            // 
            this.signUpShowPassword.AutoSize = true;
            this.signUpShowPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.signUpShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpShowPassword.Location = new System.Drawing.Point(8, 307);
            this.signUpShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.signUpShowPassword.Name = "signUpShowPassword";
            this.signUpShowPassword.Size = new System.Drawing.Size(122, 20);
            this.signUpShowPassword.TabIndex = 9;
            this.signUpShowPassword.Text = "Show Password";
            this.signUpShowPassword.UseVisualStyleBackColor = false;
            this.signUpShowPassword.CheckedChanged += new System.EventHandler(this.signUpShowPassword_CheckedChanged);
            // 
            // confirmationCHECKBOX
            // 
            this.confirmationCHECKBOX.AutoSize = true;
            this.confirmationCHECKBOX.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.confirmationCHECKBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmationCHECKBOX.Location = new System.Drawing.Point(112, 361);
            this.confirmationCHECKBOX.Margin = new System.Windows.Forms.Padding(2);
            this.confirmationCHECKBOX.Name = "confirmationCHECKBOX";
            this.confirmationCHECKBOX.Size = new System.Drawing.Size(164, 20);
            this.confirmationCHECKBOX.TabIndex = 10;
            this.confirmationCHECKBOX.Text = "I confirm my Information";
            this.confirmationCHECKBOX.UseVisualStyleBackColor = false;
            // 
            // signupBTN
            // 
            this.signupBTN.BackColor = System.Drawing.Color.DimGray;
            this.signupBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signupBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signupBTN.Location = new System.Drawing.Point(142, 385);
            this.signupBTN.Margin = new System.Windows.Forms.Padding(2);
            this.signupBTN.Name = "signupBTN";
            this.signupBTN.Size = new System.Drawing.Size(119, 51);
            this.signupBTN.TabIndex = 11;
            this.signupBTN.Text = "Sign UP";
            this.signupBTN.UseVisualStyleBackColor = false;
            this.signupBTN.Click += new System.EventHandler(this.signupBTN_Click);
            // 
            // usernameTXT
            // 
            this.usernameTXT.Location = new System.Drawing.Point(156, 157);
            this.usernameTXT.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTXT.Multiline = true;
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(222, 28);
            this.usernameTXT.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 158);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "User Name";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(156, 202);
            this.passwordTXT.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTXT.Multiline = true;
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(222, 28);
            this.passwordTXT.TabIndex = 7;
            this.passwordTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTXT_KeyPress);
            // 
            // confirmpasswordTXT
            // 
            this.confirmpasswordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.confirmpasswordTXT.Location = new System.Drawing.Point(156, 259);
            this.confirmpasswordTXT.Margin = new System.Windows.Forms.Padding(2);
            this.confirmpasswordTXT.Multiline = true;
            this.confirmpasswordTXT.Name = "confirmpasswordTXT";
            this.confirmpasswordTXT.Size = new System.Drawing.Size(222, 28);
            this.confirmpasswordTXT.TabIndex = 8;
            this.confirmpasswordTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmpasswordTXT_KeyPress);
            // 
            // providerphonenumberTXT
            // 
            this.providerphonenumberTXT.Location = new System.Drawing.Point(156, 103);
            this.providerphonenumberTXT.Margin = new System.Windows.Forms.Padding(2);
            this.providerphonenumberTXT.Multiline = true;
            this.providerphonenumberTXT.Name = "providerphonenumberTXT";
            this.providerphonenumberTXT.Size = new System.Drawing.Size(222, 28);
            this.providerphonenumberTXT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // emailTXT
            // 
            this.emailTXT.Location = new System.Drawing.Point(156, 50);
            this.emailTXT.Margin = new System.Windows.Forms.Padding(2);
            this.emailTXT.Multiline = true;
            this.emailTXT.Name = "emailTXT";
            this.emailTXT.Size = new System.Drawing.Size(222, 28);
            this.emailTXT.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Already have an account?";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.logInShowPassword);
            this.groupBox2.Controls.Add(this.loginBTN);
            this.groupBox2.Controls.Add(this.loginnameTXT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.loginpasswordTXT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 117);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(378, 226);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Log In";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // logInShowPassword
            // 
            this.logInShowPassword.AutoSize = true;
            this.logInShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInShowPassword.Location = new System.Drawing.Point(21, 136);
            this.logInShowPassword.Name = "logInShowPassword";
            this.logInShowPassword.Size = new System.Drawing.Size(122, 20);
            this.logInShowPassword.TabIndex = 3;
            this.logInShowPassword.Text = "Show Password";
            this.logInShowPassword.UseVisualStyleBackColor = true;
            this.logInShowPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.DimGray;
            this.loginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBTN.Location = new System.Drawing.Point(130, 171);
            this.loginBTN.Margin = new System.Windows.Forms.Padding(2);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(119, 51);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // loginnameTXT
            // 
            this.loginnameTXT.Location = new System.Drawing.Point(161, 43);
            this.loginnameTXT.Margin = new System.Windows.Forms.Padding(2);
            this.loginnameTXT.Multiline = true;
            this.loginnameTXT.Name = "loginnameTXT";
            this.loginnameTXT.Size = new System.Drawing.Size(196, 28);
            this.loginnameTXT.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "User Name";
            // 
            // loginpasswordTXT
            // 
            this.loginpasswordTXT.Location = new System.Drawing.Point(161, 89);
            this.loginpasswordTXT.Margin = new System.Windows.Forms.Padding(2);
            this.loginpasswordTXT.Multiline = true;
            this.loginpasswordTXT.Name = "loginpasswordTXT";
            this.loginpasswordTXT.Size = new System.Drawing.Size(196, 28);
            this.loginpasswordTXT.TabIndex = 1;
            this.loginpasswordTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginpasswordTXT_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Password";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(43, 78);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 31);
            this.label13.TabIndex = 12;
            this.label13.Text = "Login Here";
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.DimGray;
            this.backBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBTN.Location = new System.Drawing.Point(40, 469);
            this.backBTN.Margin = new System.Windows.Forms.Padding(2);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(119, 58);
            this.backBTN.TabIndex = 12;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // swiftTrackDataSet
            // 
            this.swiftTrackDataSet.DataSetName = "SwiftTrackDataSet";
            this.swiftTrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "provider";
            this.providerBindingSource.DataSource = this.swiftTrackDataSet;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // Provider_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 548);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Provider_Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provider_Account";
            this.Activated += new System.EventHandler(this.Provider_Account_Activated);
            this.Deactivate += new System.EventHandler(this.Provider_Account_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Provider_Account_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Provider_Account_FormClosed);
            this.Load += new System.EventHandler(this.Provider_Account_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox usernameTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.TextBox confirmpasswordTXT;
        private System.Windows.Forms.TextBox providerphonenumberTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox loginnameTXT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox loginpasswordTXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button signupBTN;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.CheckBox confirmationCHECKBOX;
        private System.Windows.Forms.Button backBTN;
        private SwiftTrackDataSet swiftTrackDataSet;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private SwiftTrackDataSetTableAdapters.providerTableAdapter providerTableAdapter;
        private System.Windows.Forms.CheckBox logInShowPassword;
        private System.Windows.Forms.CheckBox signUpShowPassword;
    }
}