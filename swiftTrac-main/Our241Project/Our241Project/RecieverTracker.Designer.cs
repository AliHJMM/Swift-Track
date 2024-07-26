namespace Our241Project
{
    partial class RecieverTracker
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
            this.shipmentIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBtn = new System.Windows.Forms.Button();
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.ShipmentTableAdapter();
            this.courierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courierTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.CourierTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTxt = new System.Windows.Forms.Label();
            this.weightTxt = new System.Windows.Forms.Label();
            this.courierNumberTxt = new System.Windows.Forms.Label();
            this.CourierNameTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipmentIdTxt
            // 
            this.shipmentIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipmentIdTxt.Location = new System.Drawing.Point(220, 129);
            this.shipmentIdTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmentIdTxt.Multiline = true;
            this.shipmentIdTxt.Name = "shipmentIdTxt";
            this.shipmentIdTxt.Size = new System.Drawing.Size(248, 29);
            this.shipmentIdTxt.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(553, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter The shipment ID ToTrack Your Shipment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment ID:";
            // 
            // trackBtn
            // 
            this.trackBtn.BackColor = System.Drawing.Color.DimGray;
            this.trackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trackBtn.Location = new System.Drawing.Point(545, 119);
            this.trackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBtn.Name = "trackBtn";
            this.trackBtn.Size = new System.Drawing.Size(264, 48);
            this.trackBtn.TabIndex = 1;
            this.trackBtn.Text = "Track Order";
            this.trackBtn.UseVisualStyleBackColor = false;
            this.trackBtn.Click += new System.EventHandler(this.trackBtn_Click);
            // 
            // swiftTrackDataSet
            // 
            this.swiftTrackDataSet.DataSetName = "SwiftTrackDataSet";
            this.swiftTrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.swiftTrackDataSet;
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // courierBindingSource
            // 
            this.courierBindingSource.DataMember = "Courier";
            this.courierBindingSource.DataSource = this.swiftTrackDataSet;
            // 
            // courierTableAdapter
            // 
            this.courierTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.dateTxt);
            this.groupBox1.Controls.Add(this.weightTxt);
            this.groupBox1.Controls.Add(this.courierNumberTxt);
            this.groupBox1.Controls.Add(this.CourierNameTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 217);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(764, 318);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipment Information";
            this.groupBox1.Visible = false;
            // 
            // dateTxt
            // 
            this.dateTxt.AutoSize = true;
            this.dateTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTxt.Location = new System.Drawing.Point(392, 171);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.Size = new System.Drawing.Size(2, 31);
            this.dateTxt.TabIndex = 9;
            // 
            // weightTxt
            // 
            this.weightTxt.AutoSize = true;
            this.weightTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.weightTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTxt.Location = new System.Drawing.Point(392, 224);
            this.weightTxt.Name = "weightTxt";
            this.weightTxt.Size = new System.Drawing.Size(2, 31);
            this.weightTxt.TabIndex = 8;
            // 
            // courierNumberTxt
            // 
            this.courierNumberTxt.AutoSize = true;
            this.courierNumberTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.courierNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courierNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courierNumberTxt.Location = new System.Drawing.Point(392, 116);
            this.courierNumberTxt.Name = "courierNumberTxt";
            this.courierNumberTxt.Size = new System.Drawing.Size(2, 31);
            this.courierNumberTxt.TabIndex = 7;
            // 
            // CourierNameTxt
            // 
            this.CourierNameTxt.AutoSize = true;
            this.CourierNameTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CourierNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourierNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourierNameTxt.Location = new System.Drawing.Point(392, 59);
            this.CourierNameTxt.Name = "CourierNameTxt";
            this.CourierNameTxt.Size = new System.Drawing.Size(2, 31);
            this.CourierNameTxt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(320, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shipment Delivery Date is:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shipment Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(302, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Courier Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Courier Name:";
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.DimGray;
            this.backBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBTN.Location = new System.Drawing.Point(308, 551);
            this.backBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(240, 48);
            this.backBTN.TabIndex = 33;
            this.backBTN.Text = "Go Back";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // RecieverTracker
            // 
            this.AcceptButton = this.trackBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.backBTN;
            this.ClientSize = new System.Drawing.Size(867, 610);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trackBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipmentIdTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecieverTracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecieverTracker";
            this.Activated += new System.EventHandler(this.RecieverTracker_Activated);
            this.Deactivate += new System.EventHandler(this.RecieverTracker_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecieverTracker_FormClosed);
            this.Load += new System.EventHandler(this.RecieverTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courierBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox shipmentIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trackBtn;
        private SwiftTrackDataSet swiftTrackDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private SwiftTrackDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.BindingSource courierBindingSource;
        private SwiftTrackDataSetTableAdapters.CourierTableAdapter courierTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateTxt;
        private System.Windows.Forms.Label weightTxt;
        private System.Windows.Forms.Label courierNumberTxt;
        private System.Windows.Forms.Label CourierNameTxt;
        private System.Windows.Forms.Button backBTN;
    }
}