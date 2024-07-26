namespace Our241Project
{
    partial class ShipmentModifier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.recieveraddressTXT = new System.Windows.Forms.TextBox();
            this.recievrlbl = new System.Windows.Forms.Label();
            this.recieverzipTXT = new System.Windows.Forms.TextBox();
            this.recievelbl = new System.Windows.Forms.Label();
            this.priceTXT = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.postingdateTXT = new System.Windows.Forms.TextBox();
            this.postinglbl = new System.Windows.Forms.Label();
            this.servicetypeTXT = new System.Windows.Forms.TextBox();
            this.serlbl = new System.Windows.Forms.Label();
            this.weightTXT = new System.Windows.Forms.TextBox();
            this.totweightLBL = new System.Windows.Forms.Label();
            this.docsTXT = new System.Windows.Forms.TextBox();
            this.documentsTXT = new System.Windows.Forms.Label();
            this.parcelsTXT = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.recieverfullnameTXT = new System.Windows.Forms.TextBox();
            this.recievernameTXT = new System.Windows.Forms.Label();
            this.providerfullnameTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shipmenttabledatagridview = new System.Windows.Forms.DataGridView();
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.ShipmentTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.shipmentIDTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.courierIDTXT = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveBTN = new System.Windows.Forms.Button();
            this.changeBTN = new System.Windows.Forms.Button();
            this.shipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverZip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rownumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.changeBTN);
            this.panel1.Controls.Add(this.retrieveBTN);
            this.panel1.Controls.Add(this.courierIDTXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.shipmentIDTXT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.recieveraddressTXT);
            this.panel1.Controls.Add(this.recievrlbl);
            this.panel1.Controls.Add(this.recieverzipTXT);
            this.panel1.Controls.Add(this.recievelbl);
            this.panel1.Controls.Add(this.priceTXT);
            this.panel1.Controls.Add(this.pricelbl);
            this.panel1.Controls.Add(this.postingdateTXT);
            this.panel1.Controls.Add(this.postinglbl);
            this.panel1.Controls.Add(this.servicetypeTXT);
            this.panel1.Controls.Add(this.serlbl);
            this.panel1.Controls.Add(this.weightTXT);
            this.panel1.Controls.Add(this.totweightLBL);
            this.panel1.Controls.Add(this.docsTXT);
            this.panel1.Controls.Add(this.documentsTXT);
            this.panel1.Controls.Add(this.parcelsTXT);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.recieverfullnameTXT);
            this.panel1.Controls.Add(this.recievernameTXT);
            this.panel1.Controls.Add(this.providerfullnameTXT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1549, 234);
            this.panel1.TabIndex = 33;
            // 
            // recieveraddressTXT
            // 
            this.recieveraddressTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.recieveraddressTXT.Location = new System.Drawing.Point(1338, 121);
            this.recieveraddressTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recieveraddressTXT.Multiline = true;
            this.recieveraddressTXT.Name = "recieveraddressTXT";
            this.recieveraddressTXT.Size = new System.Drawing.Size(199, 31);
            this.recieveraddressTXT.TabIndex = 9;
            // 
            // recievrlbl
            // 
            this.recievrlbl.AutoSize = true;
            this.recievrlbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievrlbl.ForeColor = System.Drawing.Color.Black;
            this.recievrlbl.Location = new System.Drawing.Point(1156, 121);
            this.recievrlbl.Name = "recievrlbl";
            this.recievrlbl.Size = new System.Drawing.Size(177, 25);
            this.recievrlbl.TabIndex = 55;
            this.recievrlbl.Text = "RecieverAddress";
            // 
            // recieverzipTXT
            // 
            this.recieverzipTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.recieverzipTXT.Location = new System.Drawing.Point(950, 121);
            this.recieverzipTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recieverzipTXT.Multiline = true;
            this.recieverzipTXT.Name = "recieverzipTXT";
            this.recieverzipTXT.Size = new System.Drawing.Size(200, 31);
            this.recieverzipTXT.TabIndex = 6;
            // 
            // recievelbl
            // 
            this.recievelbl.AutoSize = true;
            this.recievelbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievelbl.ForeColor = System.Drawing.Color.Black;
            this.recievelbl.Location = new System.Drawing.Point(771, 120);
            this.recievelbl.Name = "recievelbl";
            this.recievelbl.Size = new System.Drawing.Size(132, 25);
            this.recievelbl.TabIndex = 53;
            this.recievelbl.Text = "RecieverZip";
            // 
            // priceTXT
            // 
            this.priceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.priceTXT.Location = new System.Drawing.Point(548, 121);
            this.priceTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTXT.Multiline = true;
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(199, 31);
            this.priceTXT.TabIndex = 5;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.Black;
            this.pricelbl.Location = new System.Drawing.Point(402, 120);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(66, 25);
            this.pricelbl.TabIndex = 51;
            this.pricelbl.Text = "Price";
            // 
            // postingdateTXT
            // 
            this.postingdateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.postingdateTXT.Location = new System.Drawing.Point(170, 121);
            this.postingdateTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postingdateTXT.Multiline = true;
            this.postingdateTXT.Name = "postingdateTXT";
            this.postingdateTXT.Size = new System.Drawing.Size(199, 31);
            this.postingdateTXT.TabIndex = 4;
            // 
            // postinglbl
            // 
            this.postinglbl.AutoSize = true;
            this.postinglbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postinglbl.ForeColor = System.Drawing.Color.Black;
            this.postinglbl.Location = new System.Drawing.Point(14, 120);
            this.postinglbl.Name = "postinglbl";
            this.postinglbl.Size = new System.Drawing.Size(136, 25);
            this.postinglbl.TabIndex = 49;
            this.postinglbl.Text = "PostingDate";
            // 
            // servicetypeTXT
            // 
            this.servicetypeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.servicetypeTXT.Location = new System.Drawing.Point(1338, 72);
            this.servicetypeTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.servicetypeTXT.Multiline = true;
            this.servicetypeTXT.Name = "servicetypeTXT";
            this.servicetypeTXT.Size = new System.Drawing.Size(199, 31);
            this.servicetypeTXT.TabIndex = 8;
            // 
            // serlbl
            // 
            this.serlbl.AutoSize = true;
            this.serlbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serlbl.ForeColor = System.Drawing.Color.Black;
            this.serlbl.Location = new System.Drawing.Point(1164, 70);
            this.serlbl.Name = "serlbl";
            this.serlbl.Size = new System.Drawing.Size(139, 25);
            this.serlbl.TabIndex = 47;
            this.serlbl.Text = "Service Type";
            // 
            // weightTXT
            // 
            this.weightTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.weightTXT.Location = new System.Drawing.Point(950, 72);
            this.weightTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weightTXT.Multiline = true;
            this.weightTXT.Name = "weightTXT";
            this.weightTXT.Size = new System.Drawing.Size(199, 31);
            this.weightTXT.TabIndex = 7;
            // 
            // totweightLBL
            // 
            this.totweightLBL.AutoSize = true;
            this.totweightLBL.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totweightLBL.ForeColor = System.Drawing.Color.Black;
            this.totweightLBL.Location = new System.Drawing.Point(771, 70);
            this.totweightLBL.Name = "totweightLBL";
            this.totweightLBL.Size = new System.Drawing.Size(140, 25);
            this.totweightLBL.TabIndex = 45;
            this.totweightLBL.Text = "TotalWeight";
            // 
            // docsTXT
            // 
            this.docsTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.docsTXT.Location = new System.Drawing.Point(548, 66);
            this.docsTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.docsTXT.Multiline = true;
            this.docsTXT.Name = "docsTXT";
            this.docsTXT.Size = new System.Drawing.Size(199, 31);
            this.docsTXT.TabIndex = 3;
            // 
            // documentsTXT
            // 
            this.documentsTXT.AutoSize = true;
            this.documentsTXT.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsTXT.ForeColor = System.Drawing.Color.Black;
            this.documentsTXT.Location = new System.Drawing.Point(375, 66);
            this.documentsTXT.Name = "documentsTXT";
            this.documentsTXT.Size = new System.Drawing.Size(161, 25);
            this.documentsTXT.TabIndex = 43;
            this.documentsTXT.Text = "Documents.NO";
            // 
            // parcelsTXT
            // 
            this.parcelsTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.parcelsTXT.Location = new System.Drawing.Point(170, 65);
            this.parcelsTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parcelsTXT.Multiline = true;
            this.parcelsTXT.Name = "parcelsTXT";
            this.parcelsTXT.Size = new System.Drawing.Size(199, 31);
            this.parcelsTXT.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(14, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(126, 25);
            this.lbl.TabIndex = 41;
            this.lbl.Text = "Parcels.NO";
            // 
            // recieverfullnameTXT
            // 
            this.recieverfullnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.recieverfullnameTXT.Location = new System.Drawing.Point(1338, 22);
            this.recieverfullnameTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recieverfullnameTXT.Multiline = true;
            this.recieverfullnameTXT.Name = "recieverfullnameTXT";
            this.recieverfullnameTXT.Size = new System.Drawing.Size(199, 31);
            this.recieverfullnameTXT.TabIndex = 1;
            // 
            // recievernameTXT
            // 
            this.recievernameTXT.AutoSize = true;
            this.recievernameTXT.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recievernameTXT.ForeColor = System.Drawing.Color.Black;
            this.recievernameTXT.Location = new System.Drawing.Point(1164, 22);
            this.recievernameTXT.Name = "recievernameTXT";
            this.recievernameTXT.Size = new System.Drawing.Size(155, 25);
            this.recievernameTXT.TabIndex = 39;
            this.recievernameTXT.Text = "RecieverName";
            // 
            // providerfullnameTXT
            // 
            this.providerfullnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.providerfullnameTXT.Location = new System.Drawing.Point(950, 23);
            this.providerfullnameTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providerfullnameTXT.Multiline = true;
            this.providerfullnameTXT.Name = "providerfullnameTXT";
            this.providerfullnameTXT.Size = new System.Drawing.Size(199, 31);
            this.providerfullnameTXT.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(771, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "ProviderName";
            // 
            // shipmenttabledatagridview
            // 
            this.shipmenttabledatagridview.AutoGenerateColumns = false;
            this.shipmenttabledatagridview.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.shipmenttabledatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipmenttabledatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmenttabledatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipmentID,
            this.courierID,
            this.providerName,
            this.recieverName,
            this.parcels,
            this.documents,
            this.totalWeight,
            this.serviceType,
            this.postingDate,
            this.price,
            this.recieverZip,
            this.recieverAddress,
            this.rownumber});
            this.shipmenttabledatagridview.DataSource = this.shipmentBindingSource;
            this.shipmenttabledatagridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shipmenttabledatagridview.Location = new System.Drawing.Point(0, 400);
            this.shipmenttabledatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmenttabledatagridview.Name = "shipmenttabledatagridview";
            this.shipmenttabledatagridview.RowHeadersWidth = 51;
            this.shipmenttabledatagridview.RowTemplate.Height = 24;
            this.shipmenttabledatagridview.Size = new System.Drawing.Size(1549, 306);
            this.shipmenttabledatagridview.TabIndex = 34;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "ShipmentID";
            // 
            // shipmentIDTXT
            // 
            this.shipmentIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.shipmentIDTXT.Location = new System.Drawing.Point(170, 17);
            this.shipmentIDTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmentIDTXT.Multiline = true;
            this.shipmentIDTXT.Name = "shipmentIDTXT";
            this.shipmentIDTXT.Size = new System.Drawing.Size(199, 31);
            this.shipmentIDTXT.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(402, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "CourierID";
            // 
            // courierIDTXT
            // 
            this.courierIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.courierIDTXT.Location = new System.Drawing.Point(548, 22);
            this.courierIDTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courierIDTXT.Multiline = true;
            this.courierIDTXT.Name = "courierIDTXT";
            this.courierIDTXT.Size = new System.Drawing.Size(199, 31);
            this.courierIDTXT.TabIndex = 59;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1549, 28);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // retrieveBTN
            // 
            this.retrieveBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.retrieveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.retrieveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrieveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retrieveBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.retrieveBTN.Location = new System.Drawing.Point(460, 177);
            this.retrieveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retrieveBTN.Name = "retrieveBTN";
            this.retrieveBTN.Size = new System.Drawing.Size(309, 55);
            this.retrieveBTN.TabIndex = 61;
            this.retrieveBTN.Text = "Retrieve Shipment";
            this.retrieveBTN.UseVisualStyleBackColor = false;
            this.retrieveBTN.Click += new System.EventHandler(this.retrieveBTN_Click);
            // 
            // changeBTN
            // 
            this.changeBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.changeBTN.Location = new System.Drawing.Point(788, 177);
            this.changeBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(309, 55);
            this.changeBTN.TabIndex = 62;
            this.changeBTN.Text = "Change Shipment";
            this.changeBTN.UseVisualStyleBackColor = false;
            this.changeBTN.Click += new System.EventHandler(this.changeBTN_Click);
            // 
            // shipmentID
            // 
            this.shipmentID.DataPropertyName = "shipmentID";
            this.shipmentID.HeaderText = "shipmentID";
            this.shipmentID.MinimumWidth = 6;
            this.shipmentID.Name = "shipmentID";
            this.shipmentID.Width = 125;
            // 
            // courierID
            // 
            this.courierID.DataPropertyName = "courierID";
            this.courierID.HeaderText = "courierID";
            this.courierID.MinimumWidth = 6;
            this.courierID.Name = "courierID";
            this.courierID.Width = 125;
            // 
            // providerName
            // 
            this.providerName.DataPropertyName = "providerName";
            this.providerName.HeaderText = "providerName";
            this.providerName.MinimumWidth = 6;
            this.providerName.Name = "providerName";
            this.providerName.Width = 125;
            // 
            // recieverName
            // 
            this.recieverName.DataPropertyName = "recieverName";
            this.recieverName.HeaderText = "recieverName";
            this.recieverName.MinimumWidth = 6;
            this.recieverName.Name = "recieverName";
            this.recieverName.Width = 125;
            // 
            // parcels
            // 
            this.parcels.DataPropertyName = "parcels";
            this.parcels.HeaderText = "parcels";
            this.parcels.MinimumWidth = 6;
            this.parcels.Name = "parcels";
            this.parcels.Width = 125;
            // 
            // documents
            // 
            this.documents.DataPropertyName = "documents";
            this.documents.HeaderText = "documents";
            this.documents.MinimumWidth = 6;
            this.documents.Name = "documents";
            this.documents.Width = 125;
            // 
            // totalWeight
            // 
            this.totalWeight.DataPropertyName = "totalWeight";
            this.totalWeight.HeaderText = "totalWeight";
            this.totalWeight.MinimumWidth = 6;
            this.totalWeight.Name = "totalWeight";
            this.totalWeight.Width = 125;
            // 
            // serviceType
            // 
            this.serviceType.DataPropertyName = "serviceType";
            this.serviceType.HeaderText = "serviceType";
            this.serviceType.MinimumWidth = 6;
            this.serviceType.Name = "serviceType";
            this.serviceType.Width = 125;
            // 
            // postingDate
            // 
            this.postingDate.DataPropertyName = "postingDate";
            this.postingDate.HeaderText = "postingDate";
            this.postingDate.MinimumWidth = 6;
            this.postingDate.Name = "postingDate";
            this.postingDate.Width = 125;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // recieverZip
            // 
            this.recieverZip.DataPropertyName = "recieverZip";
            this.recieverZip.HeaderText = "recieverZip";
            this.recieverZip.MinimumWidth = 6;
            this.recieverZip.Name = "recieverZip";
            this.recieverZip.Width = 125;
            // 
            // recieverAddress
            // 
            this.recieverAddress.DataPropertyName = "recieverAddress";
            this.recieverAddress.HeaderText = "recieverAddress";
            this.recieverAddress.MinimumWidth = 6;
            this.recieverAddress.Name = "recieverAddress";
            this.recieverAddress.Width = 125;
            // 
            // rownumber
            // 
            this.rownumber.DataPropertyName = "rownumber";
            this.rownumber.HeaderText = "rownumber";
            this.rownumber.MinimumWidth = 6;
            this.rownumber.Name = "rownumber";
            this.rownumber.Visible = false;
            this.rownumber.Width = 125;
            // 
            // ShipmentModifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1549, 706);
            this.Controls.Add(this.shipmenttabledatagridview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ShipmentModifier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipment_Modifier";
            this.Activated += new System.EventHandler(this.ShipmentModifier_Activated);
            this.Deactivate += new System.EventHandler(this.ShipmentModifier_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ShipmentModifier_FormClosed);
            this.Load += new System.EventHandler(this.Shipment_Modifier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox recieveraddressTXT;
        public System.Windows.Forms.Label recievrlbl;
        private System.Windows.Forms.TextBox recieverzipTXT;
        public System.Windows.Forms.Label recievelbl;
        private System.Windows.Forms.TextBox priceTXT;
        public System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox postingdateTXT;
        public System.Windows.Forms.Label postinglbl;
        private System.Windows.Forms.TextBox servicetypeTXT;
        public System.Windows.Forms.Label serlbl;
        private System.Windows.Forms.TextBox weightTXT;
        public System.Windows.Forms.Label totweightLBL;
        private System.Windows.Forms.TextBox docsTXT;
        public System.Windows.Forms.Label documentsTXT;
        private System.Windows.Forms.TextBox parcelsTXT;
        public System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox recieverfullnameTXT;
        public System.Windows.Forms.Label recievernameTXT;
        private System.Windows.Forms.TextBox providerfullnameTXT;
        public System.Windows.Forms.Label label4;
        private SwiftTrackDataSet swiftTrackDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private SwiftTrackDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courierIDTXT;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shipmentIDTXT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button retrieveBTN;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcels;
        private System.Windows.Forms.DataGridViewTextBoxColumn documents;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn postingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverZip;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn rownumber;
        public System.Windows.Forms.DataGridView shipmenttabledatagridview;
    }
}