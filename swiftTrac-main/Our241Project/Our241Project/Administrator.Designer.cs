namespace Our241Project
{
    partial class Administrator
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
            this.shipmenttabledatagridview = new System.Windows.Forms.DataGridView();
            this.shipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.previousBTN = new System.Windows.Forms.Button();
            this.firstBTN = new System.Windows.Forms.Button();
            this.lastBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.insertBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
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
            this.shipmentidTXT = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackerConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipmentTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.ShipmentTableAdapter();
            this.clearBtn = new System.Windows.Forms.Button();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shipmenttabledatagridview
            // 
            this.shipmenttabledatagridview.AutoGenerateColumns = false;
            this.shipmenttabledatagridview.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.shipmenttabledatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipmenttabledatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipmenttabledatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipmentIDDataGridViewTextBoxColumn,
            this.courierIDDataGridViewTextBoxColumn,
            this.providerNameDataGridViewTextBoxColumn,
            this.recieverNameDataGridViewTextBoxColumn,
            this.parcelsDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.totalWeight,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.postingDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.recieverZipDataGridViewTextBoxColumn,
            this.recieverAddressDataGridViewTextBoxColumn});
            this.shipmenttabledatagridview.DataSource = this.shipmentBindingSource;
            this.shipmenttabledatagridview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.shipmenttabledatagridview.Location = new System.Drawing.Point(0, 489);
            this.shipmenttabledatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmenttabledatagridview.Name = "shipmenttabledatagridview";
            this.shipmenttabledatagridview.RowHeadersWidth = 51;
            this.shipmenttabledatagridview.RowTemplate.Height = 24;
            this.shipmenttabledatagridview.Size = new System.Drawing.Size(1528, 306);
            this.shipmenttabledatagridview.TabIndex = 18;
            // 
            // shipmentIDDataGridViewTextBoxColumn
            // 
            this.shipmentIDDataGridViewTextBoxColumn.DataPropertyName = "shipmentID";
            this.shipmentIDDataGridViewTextBoxColumn.HeaderText = "shipmentID";
            this.shipmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipmentIDDataGridViewTextBoxColumn.Name = "shipmentIDDataGridViewTextBoxColumn";
            this.shipmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.shipmentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // courierIDDataGridViewTextBoxColumn
            // 
            this.courierIDDataGridViewTextBoxColumn.DataPropertyName = "courierID";
            this.courierIDDataGridViewTextBoxColumn.HeaderText = "courierID";
            this.courierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courierIDDataGridViewTextBoxColumn.Name = "courierIDDataGridViewTextBoxColumn";
            this.courierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // providerNameDataGridViewTextBoxColumn
            // 
            this.providerNameDataGridViewTextBoxColumn.DataPropertyName = "providerName";
            this.providerNameDataGridViewTextBoxColumn.HeaderText = "providerName";
            this.providerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.providerNameDataGridViewTextBoxColumn.Name = "providerNameDataGridViewTextBoxColumn";
            this.providerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // recieverNameDataGridViewTextBoxColumn
            // 
            this.recieverNameDataGridViewTextBoxColumn.DataPropertyName = "recieverName";
            this.recieverNameDataGridViewTextBoxColumn.HeaderText = "recieverName";
            this.recieverNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recieverNameDataGridViewTextBoxColumn.Name = "recieverNameDataGridViewTextBoxColumn";
            this.recieverNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // parcelsDataGridViewTextBoxColumn
            // 
            this.parcelsDataGridViewTextBoxColumn.DataPropertyName = "parcels";
            this.parcelsDataGridViewTextBoxColumn.HeaderText = "parcels";
            this.parcelsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parcelsDataGridViewTextBoxColumn.Name = "parcelsDataGridViewTextBoxColumn";
            this.parcelsDataGridViewTextBoxColumn.Width = 125;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "documents";
            this.documentsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalWeight
            // 
            this.totalWeight.DataPropertyName = "totalWeight";
            this.totalWeight.HeaderText = "totalWeight";
            this.totalWeight.MinimumWidth = 6;
            this.totalWeight.Name = "totalWeight";
            this.totalWeight.Width = 125;
            // 
            // serviceTypeDataGridViewTextBoxColumn
            // 
            this.serviceTypeDataGridViewTextBoxColumn.DataPropertyName = "serviceType";
            this.serviceTypeDataGridViewTextBoxColumn.HeaderText = "serviceType";
            this.serviceTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceTypeDataGridViewTextBoxColumn.Name = "serviceTypeDataGridViewTextBoxColumn";
            this.serviceTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // postingDateDataGridViewTextBoxColumn
            // 
            this.postingDateDataGridViewTextBoxColumn.DataPropertyName = "postingDate";
            this.postingDateDataGridViewTextBoxColumn.HeaderText = "postingDate";
            this.postingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.postingDateDataGridViewTextBoxColumn.Name = "postingDateDataGridViewTextBoxColumn";
            this.postingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // recieverZipDataGridViewTextBoxColumn
            // 
            this.recieverZipDataGridViewTextBoxColumn.DataPropertyName = "recieverZip";
            this.recieverZipDataGridViewTextBoxColumn.HeaderText = "recieverZip";
            this.recieverZipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recieverZipDataGridViewTextBoxColumn.Name = "recieverZipDataGridViewTextBoxColumn";
            this.recieverZipDataGridViewTextBoxColumn.Width = 125;
            // 
            // recieverAddressDataGridViewTextBoxColumn
            // 
            this.recieverAddressDataGridViewTextBoxColumn.DataPropertyName = "recieverAddress";
            this.recieverAddressDataGridViewTextBoxColumn.HeaderText = "recieverAddress";
            this.recieverAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recieverAddressDataGridViewTextBoxColumn.Name = "recieverAddressDataGridViewTextBoxColumn";
            this.recieverAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // shipmentBindingSource
            // 
            this.shipmentBindingSource.DataMember = "Shipment";
            this.shipmentBindingSource.DataSource = this.swiftTrackDataSet;
            // 
            // swiftTrackDataSet
            // 
            this.swiftTrackDataSet.DataSetName = "SwiftTrackDataSet";
            this.swiftTrackDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "Admin Room";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.previousBTN);
            this.groupBox2.Controls.Add(this.firstBTN);
            this.groupBox2.Controls.Add(this.lastBTN);
            this.groupBox2.Controls.Add(this.nextBTN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(269, 177);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Movements";
            // 
            // previousBTN
            // 
            this.previousBTN.BackColor = System.Drawing.Color.DimGray;
            this.previousBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.previousBTN.Location = new System.Drawing.Point(115, 44);
            this.previousBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.previousBTN.Name = "previousBTN";
            this.previousBTN.Size = new System.Drawing.Size(148, 47);
            this.previousBTN.TabIndex = 12;
            this.previousBTN.Text = "Previous";
            this.previousBTN.UseVisualStyleBackColor = false;
            this.previousBTN.Click += new System.EventHandler(this.previousBTN_Click);
            // 
            // firstBTN
            // 
            this.firstBTN.BackColor = System.Drawing.Color.DimGray;
            this.firstBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.firstBTN.Location = new System.Drawing.Point(115, 114);
            this.firstBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstBTN.Name = "firstBTN";
            this.firstBTN.Size = new System.Drawing.Size(148, 47);
            this.firstBTN.TabIndex = 14;
            this.firstBTN.Text = "First";
            this.firstBTN.UseVisualStyleBackColor = false;
            this.firstBTN.Click += new System.EventHandler(this.firstBTN_Click);
            // 
            // lastBTN
            // 
            this.lastBTN.BackColor = System.Drawing.Color.DimGray;
            this.lastBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lastBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastBTN.Location = new System.Drawing.Point(5, 114);
            this.lastBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastBTN.Name = "lastBTN";
            this.lastBTN.Size = new System.Drawing.Size(104, 42);
            this.lastBTN.TabIndex = 13;
            this.lastBTN.Text = "Last";
            this.lastBTN.UseVisualStyleBackColor = false;
            this.lastBTN.Click += new System.EventHandler(this.lastBTN_Click);
            // 
            // nextBTN
            // 
            this.nextBTN.BackColor = System.Drawing.Color.DimGray;
            this.nextBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nextBTN.Location = new System.Drawing.Point(5, 44);
            this.nextBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(104, 47);
            this.nextBTN.TabIndex = 11;
            this.nextBTN.Text = "Next";
            this.nextBTN.UseVisualStyleBackColor = false;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.DeleBTN);
            this.groupBox1.Controls.Add(this.saveBTN);
            this.groupBox1.Controls.Add(this.addBTN);
            this.groupBox1.Controls.Add(this.insertBTN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(283, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(305, 177);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manipulation";
            // 
            // DeleBTN
            // 
            this.DeleBTN.BackColor = System.Drawing.Color.DimGray;
            this.DeleBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleBTN.Location = new System.Drawing.Point(5, 114);
            this.DeleBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleBTN.Name = "DeleBTN";
            this.DeleBTN.Size = new System.Drawing.Size(125, 50);
            this.DeleBTN.TabIndex = 17;
            this.DeleBTN.Text = "Delete";
            this.DeleBTN.UseVisualStyleBackColor = false;
            this.DeleBTN.Click += new System.EventHandler(this.DeleBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.BackColor = System.Drawing.Color.DimGray;
            this.saveBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saveBTN.Location = new System.Drawing.Point(169, 114);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(125, 50);
            this.saveBTN.TabIndex = 18;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = false;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.BackColor = System.Drawing.Color.DimGray;
            this.addBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBTN.Location = new System.Drawing.Point(5, 28);
            this.addBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(125, 82);
            this.addBTN.TabIndex = 15;
            this.addBTN.Text = "Add Manually";
            this.addBTN.UseVisualStyleBackColor = false;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // insertBTN
            // 
            this.insertBTN.BackColor = System.Drawing.Color.DimGray;
            this.insertBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.insertBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insertBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insertBTN.Location = new System.Drawing.Point(169, 28);
            this.insertBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(125, 82);
            this.insertBTN.TabIndex = 16;
            this.insertBTN.Text = "Insert Manually";
            this.insertBTN.UseVisualStyleBackColor = false;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.BackColor = System.Drawing.Color.DimGray;
            this.deleteBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteBTN.Location = new System.Drawing.Point(501, 18);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(125, 50);
            this.deleteBTN.TabIndex = 19;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = false;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.panel1.Location = new System.Drawing.Point(728, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 254);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // recieveraddressTXT
            // 
            this.recieveraddressTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.recieveraddressTXT.Location = new System.Drawing.Point(589, 186);
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
            this.recievrlbl.Location = new System.Drawing.Point(388, 190);
            this.recievrlbl.Name = "recievrlbl";
            this.recievrlbl.Size = new System.Drawing.Size(177, 25);
            this.recievrlbl.TabIndex = 55;
            this.recievrlbl.Text = "RecieverAddress";
            this.recievrlbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // recieverzipTXT
            // 
            this.recieverzipTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.recieverzipTXT.Location = new System.Drawing.Point(588, 62);
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
            this.recievelbl.Location = new System.Drawing.Point(396, 62);
            this.recievelbl.Name = "recievelbl";
            this.recievelbl.Size = new System.Drawing.Size(132, 25);
            this.recievelbl.TabIndex = 53;
            this.recievelbl.Text = "RecieverZip";
            this.recievelbl.Click += new System.EventHandler(this.recievelbl_Click);
            // 
            // priceTXT
            // 
            this.priceTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.priceTXT.Location = new System.Drawing.Point(588, 18);
            this.priceTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceTXT.Multiline = true;
            this.priceTXT.Name = "priceTXT";
            this.priceTXT.Size = new System.Drawing.Size(200, 31);
            this.priceTXT.TabIndex = 5;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.Black;
            this.pricelbl.Location = new System.Drawing.Point(396, 18);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(66, 25);
            this.pricelbl.TabIndex = 51;
            this.pricelbl.Text = "Price";
            // 
            // postingdateTXT
            // 
            this.postingdateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.postingdateTXT.Location = new System.Drawing.Point(187, 186);
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
            this.postinglbl.Location = new System.Drawing.Point(21, 186);
            this.postinglbl.Name = "postinglbl";
            this.postinglbl.Size = new System.Drawing.Size(136, 25);
            this.postinglbl.TabIndex = 49;
            this.postinglbl.Text = "PostingDate";
            // 
            // servicetypeTXT
            // 
            this.servicetypeTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.servicetypeTXT.Location = new System.Drawing.Point(589, 146);
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
            this.serlbl.Location = new System.Drawing.Point(396, 146);
            this.serlbl.Name = "serlbl";
            this.serlbl.Size = new System.Drawing.Size(139, 25);
            this.serlbl.TabIndex = 47;
            this.serlbl.Text = "Service Type";
            // 
            // weightTXT
            // 
            this.weightTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.weightTXT.Location = new System.Drawing.Point(589, 103);
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
            this.totweightLBL.Location = new System.Drawing.Point(393, 103);
            this.totweightLBL.Name = "totweightLBL";
            this.totweightLBL.Size = new System.Drawing.Size(140, 25);
            this.totweightLBL.TabIndex = 45;
            this.totweightLBL.Text = "TotalWeight";
            // 
            // docsTXT
            // 
            this.docsTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.docsTXT.Location = new System.Drawing.Point(187, 146);
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
            this.documentsTXT.Location = new System.Drawing.Point(8, 146);
            this.documentsTXT.Name = "documentsTXT";
            this.documentsTXT.Size = new System.Drawing.Size(161, 25);
            this.documentsTXT.TabIndex = 43;
            this.documentsTXT.Text = "Documents.NO";
            // 
            // parcelsTXT
            // 
            this.parcelsTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.parcelsTXT.Location = new System.Drawing.Point(187, 98);
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
            this.lbl.Location = new System.Drawing.Point(21, 98);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(126, 25);
            this.lbl.TabIndex = 41;
            this.lbl.Text = "Parcels.NO";
            // 
            // recieverfullnameTXT
            // 
            this.recieverfullnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.recieverfullnameTXT.Location = new System.Drawing.Point(187, 58);
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
            this.recievernameTXT.Location = new System.Drawing.Point(13, 58);
            this.recievernameTXT.Name = "recievernameTXT";
            this.recievernameTXT.Size = new System.Drawing.Size(155, 25);
            this.recievernameTXT.TabIndex = 39;
            this.recievernameTXT.Text = "RecieverName";
            // 
            // providerfullnameTXT
            // 
            this.providerfullnameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.providerfullnameTXT.Location = new System.Drawing.Point(187, 14);
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
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "ProviderName";
            // 
            // shipmentidTXT
            // 
            this.shipmentidTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.shipmentidTXT.Location = new System.Drawing.Point(296, 30);
            this.shipmentidTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmentidTXT.Multiline = true;
            this.shipmentidTXT.Name = "shipmentidTXT";
            this.shipmentidTXT.Size = new System.Drawing.Size(199, 31);
            this.shipmentidTXT.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.shipmentidTXT);
            this.groupBox3.Controls.Add(this.deleteBTN);
            this.groupBox3.Location = new System.Drawing.Point(728, 321);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(639, 79);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Delete By Shipment ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(165, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(437, 41);
            this.label3.TabIndex = 33;
            this.label3.Text = "Add or Insert Manually ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(619, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 62);
            this.label5.TabIndex = 34;
            this.label5.Text = "-->";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.trackerConsoleToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1528, 28);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "&Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // trackerConsoleToolStripMenuItem
            // 
            this.trackerConsoleToolStripMenuItem.Name = "trackerConsoleToolStripMenuItem";
            this.trackerConsoleToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.trackerConsoleToolStripMenuItem.Text = "&Tracker Console";
            this.trackerConsoleToolStripMenuItem.Click += new System.EventHandler(this.trackerConsoleToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.DimGray;
            this.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBtn.Location = new System.Drawing.Point(1388, 340);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(125, 50);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "&Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.modifyToolStripMenuItem.Text = "&Modify Shipments";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1528, 795);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipmenttabledatagridview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator";
            this.Activated += new System.EventHandler(this.Administrator_Activated);
            this.Deactivate += new System.EventHandler(this.Administrator_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrator_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administrator_FormClosed);
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SwiftTrackDataSet swiftTrackDataSet;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Button firstBTN;
        private System.Windows.Forms.Button lastBTN;
        private System.Windows.Forms.Button previousBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox parcelsTXT;
        public System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox recieverfullnameTXT;
        public System.Windows.Forms.Label recievernameTXT;
        private System.Windows.Forms.TextBox providerfullnameTXT;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox shipmentidTXT;
        private System.Windows.Forms.TextBox servicetypeTXT;
        public System.Windows.Forms.Label serlbl;
        private System.Windows.Forms.TextBox weightTXT;
        public System.Windows.Forms.Label totweightLBL;
        private System.Windows.Forms.TextBox docsTXT;
        public System.Windows.Forms.Label documentsTXT;
        private System.Windows.Forms.TextBox recieverzipTXT;
        public System.Windows.Forms.Label recievelbl;
        private System.Windows.Forms.TextBox priceTXT;
        public System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox postingdateTXT;
        public System.Windows.Forms.Label postinglbl;
        private System.Windows.Forms.TextBox recieveraddressTXT;
        public System.Windows.Forms.Label recievrlbl;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private SwiftTrackDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button DeleBTN;
        private System.Windows.Forms.ToolStripMenuItem trackerConsoleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        public System.Windows.Forms.DataGridView shipmenttabledatagridview;
    }
}