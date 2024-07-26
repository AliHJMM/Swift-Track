namespace Our241Project
{
    partial class Form1
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
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.recieverBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.providerBTN = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginAsAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ourToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.BackColor = System.Drawing.Color.DimGray;
            this.welcomeLBL.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLBL.ForeColor = System.Drawing.Color.Black;
            this.welcomeLBL.Location = new System.Drawing.Point(229, 49);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(455, 41);
            this.welcomeLBL.TabIndex = 0;
            this.welcomeLBL.Text = "Welcome To Swift-Track!";
            this.welcomeLBL.Click += new System.EventHandler(this.welcomeLBL_Click);
            // 
            // recieverBTN
            // 
            this.recieverBTN.BackColor = System.Drawing.Color.DimGray;
            this.recieverBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recieverBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recieverBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieverBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.recieverBTN.Location = new System.Drawing.Point(557, 300);
            this.recieverBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recieverBTN.Name = "recieverBTN";
            this.recieverBTN.Size = new System.Drawing.Size(260, 169);
            this.recieverBTN.TabIndex = 1;
            this.recieverBTN.Text = "&Receiver";
            this.recieverBTN.UseVisualStyleBackColor = false;
            this.recieverBTN.Click += new System.EventHandler(this.startBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(45, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Number one courier system in the world";
            // 
            // providerBTN
            // 
            this.providerBTN.BackColor = System.Drawing.Color.DimGray;
            this.providerBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.providerBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.providerBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providerBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.providerBTN.Location = new System.Drawing.Point(133, 300);
            this.providerBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providerBTN.Name = "providerBTN";
            this.providerBTN.Size = new System.Drawing.Size(260, 169);
            this.providerBTN.TabIndex = 0;
            this.providerBTN.Text = "&Provider";
            this.providerBTN.UseVisualStyleBackColor = false;
            this.providerBTN.Click += new System.EventHandler(this.button1_Click);
            this.providerBTN.MouseHover += new System.EventHandler(this.providerBTN_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginAsAdminToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(936, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginAsAdminToolStripMenuItem
            // 
            this.loginAsAdminToolStripMenuItem.Name = "loginAsAdminToolStripMenuItem";
            this.loginAsAdminToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.loginAsAdminToolStripMenuItem.Text = "&Login as Admin";
            this.loginAsAdminToolStripMenuItem.Click += new System.EventHandler(this.loginAsAdminToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.aboutUsToolStripMenuItem.Text = "&About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.providerBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 538);
            this.Controls.Add(this.providerBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recieverBTN);
            this.Controls.Add(this.welcomeLBL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLBL;
        private System.Windows.Forms.Button recieverBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button providerBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolTip ourToolTip;
        private System.Windows.Forms.ToolStripMenuItem loginAsAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

