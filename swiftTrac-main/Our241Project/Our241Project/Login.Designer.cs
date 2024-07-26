namespace Our241Project
{
    partial class Login
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
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.AdminTableAdapter();
            this.showPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTXT
            // 
            this.usernameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTXT.Location = new System.Drawing.Point(205, 122);
            this.usernameTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTXT.Multiline = true;
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(199, 37);
            this.usernameTXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "username:";
            // 
            // passwordTXT
            // 
            this.passwordTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTXT.Location = new System.Drawing.Point(205, 206);
            this.passwordTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTXT.Multiline = true;
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(199, 37);
            this.passwordTXT.TabIndex = 1;
            this.passwordTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordTXT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.DimGray;
            this.loginBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBTN.Location = new System.Drawing.Point(387, 362);
            this.loginBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(172, 78);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.DimGray;
            this.backBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBTN.Location = new System.Drawing.Point(20, 362);
            this.backBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(172, 78);
            this.backBTN.TabIndex = 4;
            this.backBTN.Text = "Back";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // swiftTrackDataSet
            // 
            this.swiftTrackDataSet.DataSetName = "SwiftTrackDataSet";
            this.swiftTrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.swiftTrackDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.Location = new System.Drawing.Point(83, 271);
            this.showPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(125, 20);
            this.showPassword.TabIndex = 3;
            this.showPassword.Text = "Show Password";
            this.showPassword.UseVisualStyleBackColor = true;
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.loginBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.backBTN;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTXT);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Activated += new System.EventHandler(this.Login_Activated);
            this.Deactivate += new System.EventHandler(this.Login_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Button backBTN;
        private SwiftTrackDataSet swiftTrackDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private SwiftTrackDataSetTableAdapters.AdminTableAdapter adminTableAdapter;
        private System.Windows.Forms.CheckBox showPassword;
    }
}