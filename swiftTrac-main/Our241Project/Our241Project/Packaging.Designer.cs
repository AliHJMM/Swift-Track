namespace Our241Project
{
    partial class Packaging
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
            this.packageLISTBOX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalweigthTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.packagingpriceTXT = new System.Windows.Forms.TextBox();
            this.nextBTN = new System.Windows.Forms.Button();
            this.woodPIC = new System.Windows.Forms.PictureBox();
            this.palletizationPIC = new System.Windows.Forms.PictureBox();
            this.bagedPIC = new System.Windows.Forms.PictureBox();
            this.fiberPIC = new System.Windows.Forms.PictureBox();
            this.cottonPIC = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.woodPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palletizationPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagedPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiberPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cottonPIC)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // packageLISTBOX
            // 
            this.packageLISTBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.packageLISTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packageLISTBOX.FormattingEnabled = true;
            this.packageLISTBOX.Items.AddRange(new object[] {
            "Wooded Crates",
            "Palletization",
            "Baged Cargo",
            "Fiber Board Boxes",
            "Cotton Bales"});
            this.packageLISTBOX.Location = new System.Drawing.Point(66, 216);
            this.packageLISTBOX.Margin = new System.Windows.Forms.Padding(2);
            this.packageLISTBOX.Name = "packageLISTBOX";
            this.packageLISTBOX.Size = new System.Drawing.Size(214, 169);
            this.packageLISTBOX.TabIndex = 1;
            this.packageLISTBOX.SelectedIndexChanged += new System.EventHandler(this.packageLISTBOX_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 171);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Choose Your Packaging Service";
            // 
            // totalweigthTXT
            // 
            this.totalweigthTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalweigthTXT.Location = new System.Drawing.Point(153, 486);
            this.totalweigthTXT.Margin = new System.Windows.Forms.Padding(2);
            this.totalweigthTXT.Multiline = true;
            this.totalweigthTXT.Name = "totalweigthTXT";
            this.totalweigthTXT.ReadOnly = true;
            this.totalweigthTXT.Size = new System.Drawing.Size(162, 33);
            this.totalweigthTXT.TabIndex = 8;
            this.totalweigthTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalweigthTXT.TextChanged += new System.EventHandler(this.totalweigthTXT_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 486);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Packaging Price";
            // 
            // packagingpriceTXT
            // 
            this.packagingpriceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packagingpriceTXT.Location = new System.Drawing.Point(475, 486);
            this.packagingpriceTXT.Margin = new System.Windows.Forms.Padding(2);
            this.packagingpriceTXT.Multiline = true;
            this.packagingpriceTXT.Name = "packagingpriceTXT";
            this.packagingpriceTXT.ReadOnly = true;
            this.packagingpriceTXT.Size = new System.Drawing.Size(162, 33);
            this.packagingpriceTXT.TabIndex = 14;
            this.packagingpriceTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextBTN
            // 
            this.nextBTN.BackColor = System.Drawing.Color.DimGray;
            this.nextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextBTN.Location = new System.Drawing.Point(664, 475);
            this.nextBTN.Margin = new System.Windows.Forms.Padding(2);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(101, 54);
            this.nextBTN.TabIndex = 15;
            this.nextBTN.Text = "Next";
            this.nextBTN.UseVisualStyleBackColor = false;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // woodPIC
            // 
            this.woodPIC.ErrorImage = null;
            this.woodPIC.Image = global::Our241Project.Properties.Resources.Wooden_Creates;
            this.woodPIC.Location = new System.Drawing.Point(402, 98);
            this.woodPIC.Margin = new System.Windows.Forms.Padding(2);
            this.woodPIC.Name = "woodPIC";
            this.woodPIC.Size = new System.Drawing.Size(347, 334);
            this.woodPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodPIC.TabIndex = 0;
            this.woodPIC.TabStop = false;
            this.woodPIC.Visible = false;
            this.woodPIC.Click += new System.EventHandler(this.woodPIC_Click);
            // 
            // palletizationPIC
            // 
            this.palletizationPIC.ErrorImage = null;
            this.palletizationPIC.Image = global::Our241Project.Properties.Resources.palletization_services;
            this.palletizationPIC.Location = new System.Drawing.Point(402, 98);
            this.palletizationPIC.Margin = new System.Windows.Forms.Padding(2);
            this.palletizationPIC.Name = "palletizationPIC";
            this.palletizationPIC.Size = new System.Drawing.Size(347, 334);
            this.palletizationPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.palletizationPIC.TabIndex = 16;
            this.palletizationPIC.TabStop = false;
            this.palletizationPIC.Visible = false;
            // 
            // bagedPIC
            // 
            this.bagedPIC.ErrorImage = null;
            this.bagedPIC.Image = global::Our241Project.Properties.Resources.Bagged_Cargo;
            this.bagedPIC.Location = new System.Drawing.Point(402, 98);
            this.bagedPIC.Margin = new System.Windows.Forms.Padding(2);
            this.bagedPIC.Name = "bagedPIC";
            this.bagedPIC.Size = new System.Drawing.Size(347, 334);
            this.bagedPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bagedPIC.TabIndex = 17;
            this.bagedPIC.TabStop = false;
            this.bagedPIC.Visible = false;
            // 
            // fiberPIC
            // 
            this.fiberPIC.ErrorImage = null;
            this.fiberPIC.Image = global::Our241Project.Properties.Resources.Fiberboard_Boxes;
            this.fiberPIC.Location = new System.Drawing.Point(402, 98);
            this.fiberPIC.Margin = new System.Windows.Forms.Padding(2);
            this.fiberPIC.Name = "fiberPIC";
            this.fiberPIC.Size = new System.Drawing.Size(347, 334);
            this.fiberPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiberPIC.TabIndex = 18;
            this.fiberPIC.TabStop = false;
            this.fiberPIC.Visible = false;
            // 
            // cottonPIC
            // 
            this.cottonPIC.ErrorImage = null;
            this.cottonPIC.Image = global::Our241Project.Properties.Resources.Cotton_Bale;
            this.cottonPIC.Location = new System.Drawing.Point(402, 98);
            this.cottonPIC.Margin = new System.Windows.Forms.Padding(2);
            this.cottonPIC.Name = "cottonPIC";
            this.cottonPIC.Size = new System.Drawing.Size(347, 334);
            this.cottonPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cottonPIC.TabIndex = 19;
            this.cottonPIC.TabStop = false;
            this.cottonPIC.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "We Offer The Cheapest Prices!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.exitToolStripMenuItem.Text = "&Back";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Packaging
            // 
            this.AcceptButton = this.nextBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(783, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cottonPIC);
            this.Controls.Add(this.fiberPIC);
            this.Controls.Add(this.bagedPIC);
            this.Controls.Add(this.palletizationPIC);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.packagingpriceTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalweigthTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.packageLISTBOX);
            this.Controls.Add(this.woodPIC);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Packaging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packaging";
            this.Activated += new System.EventHandler(this.Packaging_Activated);
            this.Deactivate += new System.EventHandler(this.Packaging_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Packaging_FormClosed);
            this.Load += new System.EventHandler(this.Packaging_Load);
            ((System.ComponentModel.ISupportInitialize)(this.woodPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palletizationPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagedPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiberPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cottonPIC)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox packageLISTBOX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalweigthTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox packagingpriceTXT;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.PictureBox woodPIC;
        private System.Windows.Forms.PictureBox palletizationPIC;
        private System.Windows.Forms.PictureBox bagedPIC;
        private System.Windows.Forms.PictureBox fiberPIC;
        private System.Windows.Forms.PictureBox cottonPIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}