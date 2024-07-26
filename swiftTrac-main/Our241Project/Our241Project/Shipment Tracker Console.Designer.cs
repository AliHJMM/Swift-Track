namespace Our241Project
{
    partial class Shipment_Tracker_Console
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
            this.parcelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.top5weightBTN = new System.Windows.Forms.Button();
            this.QueryDiscriptionLBL = new System.Windows.Forms.Label();
            this.top5hishestpricesBTN = new System.Windows.Forms.Button();
            this.samedayBTN = new System.Windows.Forms.Button();
            this.doortodoorBTN = new System.Windows.Forms.Button();
            this.topParcelsBTN = new System.Windows.Forms.Button();
            this.NewestshipmentsBTN = new System.Windows.Forms.Button();
            this.providersLIST = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sumofPandDBTN = new System.Windows.Forms.Button();
            this.NumofShipmentsBTN = new System.Windows.Forms.Button();
            this.averageweightperproviderBTN = new System.Windows.Forms.Button();
            this.maxweightBTN = new System.Windows.Forms.Button();
            this.totalshipmentsPriceBTN = new System.Windows.Forms.Button();
            this.shipmentsposteddatesBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrackProvidersShipments = new System.Windows.Forms.GroupBox();
            this.shipmentTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.ShipmentTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TrackProvidersShipments.SuspendLayout();
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
            this.parcelsDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.totalWeightDataGridViewTextBoxColumn,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.postingDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.recieverNameDataGridViewTextBoxColumn,
            this.recieverZipDataGridViewTextBoxColumn,
            this.recieverAddressDataGridViewTextBoxColumn});
            this.shipmenttabledatagridview.DataSource = this.shipmentBindingSource;
            this.shipmenttabledatagridview.Location = new System.Drawing.Point(-1, 469);
            this.shipmenttabledatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmenttabledatagridview.Name = "shipmenttabledatagridview";
            this.shipmenttabledatagridview.RowHeadersWidth = 51;
            this.shipmenttabledatagridview.RowTemplate.Height = 24;
            this.shipmenttabledatagridview.Size = new System.Drawing.Size(1524, 252);
            this.shipmenttabledatagridview.TabIndex = 19;
            // 
            // shipmentIDDataGridViewTextBoxColumn
            // 
            this.shipmentIDDataGridViewTextBoxColumn.DataPropertyName = "shipmentID";
            this.shipmentIDDataGridViewTextBoxColumn.HeaderText = "shipmentID";
            this.shipmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shipmentIDDataGridViewTextBoxColumn.Name = "shipmentIDDataGridViewTextBoxColumn";
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
            // totalWeightDataGridViewTextBoxColumn
            // 
            this.totalWeightDataGridViewTextBoxColumn.DataPropertyName = "totalWeight";
            this.totalWeightDataGridViewTextBoxColumn.HeaderText = "totalWeight";
            this.totalWeightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalWeightDataGridViewTextBoxColumn.Name = "totalWeightDataGridViewTextBoxColumn";
            this.totalWeightDataGridViewTextBoxColumn.Width = 125;
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
            // recieverNameDataGridViewTextBoxColumn
            // 
            this.recieverNameDataGridViewTextBoxColumn.DataPropertyName = "recieverName";
            this.recieverNameDataGridViewTextBoxColumn.HeaderText = "recieverName";
            this.recieverNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.recieverNameDataGridViewTextBoxColumn.Name = "recieverNameDataGridViewTextBoxColumn";
            this.recieverNameDataGridViewTextBoxColumn.Width = 125;
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
            // top5weightBTN
            // 
            this.top5weightBTN.BackColor = System.Drawing.Color.DimGray;
            this.top5weightBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top5weightBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.top5weightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5weightBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top5weightBTN.Location = new System.Drawing.Point(272, 44);
            this.top5weightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.top5weightBTN.Name = "top5weightBTN";
            this.top5weightBTN.Size = new System.Drawing.Size(197, 98);
            this.top5weightBTN.TabIndex = 7;
            this.top5weightBTN.Text = "Top 5 Heaviest Shipments";
            this.top5weightBTN.UseVisualStyleBackColor = false;
            this.top5weightBTN.Click += new System.EventHandler(this.top5weight_Click);
            // 
            // QueryDiscriptionLBL
            // 
            this.QueryDiscriptionLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QueryDiscriptionLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryDiscriptionLBL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QueryDiscriptionLBL.Location = new System.Drawing.Point(457, 378);
            this.QueryDiscriptionLBL.Name = "QueryDiscriptionLBL";
            this.QueryDiscriptionLBL.Size = new System.Drawing.Size(563, 89);
            this.QueryDiscriptionLBL.TabIndex = 21;
            this.QueryDiscriptionLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top5hishestpricesBTN
            // 
            this.top5hishestpricesBTN.BackColor = System.Drawing.Color.DimGray;
            this.top5hishestpricesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top5hishestpricesBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.top5hishestpricesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5hishestpricesBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top5hishestpricesBTN.Location = new System.Drawing.Point(24, 160);
            this.top5hishestpricesBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.top5hishestpricesBTN.Name = "top5hishestpricesBTN";
            this.top5hishestpricesBTN.Size = new System.Drawing.Size(197, 98);
            this.top5hishestpricesBTN.TabIndex = 8;
            this.top5hishestpricesBTN.Text = " Top 5 Highest Prices";
            this.top5hishestpricesBTN.UseVisualStyleBackColor = false;
            this.top5hishestpricesBTN.Click += new System.EventHandler(this.top5hishestprices_Click);
            // 
            // samedayBTN
            // 
            this.samedayBTN.BackColor = System.Drawing.Color.DimGray;
            this.samedayBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.samedayBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.samedayBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samedayBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.samedayBTN.Location = new System.Drawing.Point(24, 283);
            this.samedayBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.samedayBTN.Name = "samedayBTN";
            this.samedayBTN.Size = new System.Drawing.Size(197, 98);
            this.samedayBTN.TabIndex = 10;
            this.samedayBTN.Text = "Same Day Services";
            this.samedayBTN.UseVisualStyleBackColor = false;
            this.samedayBTN.Click += new System.EventHandler(this.samedayBTN_Click);
            // 
            // doortodoorBTN
            // 
            this.doortodoorBTN.BackColor = System.Drawing.Color.DimGray;
            this.doortodoorBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doortodoorBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doortodoorBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doortodoorBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.doortodoorBTN.Location = new System.Drawing.Point(273, 283);
            this.doortodoorBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doortodoorBTN.Name = "doortodoorBTN";
            this.doortodoorBTN.Size = new System.Drawing.Size(197, 98);
            this.doortodoorBTN.TabIndex = 11;
            this.doortodoorBTN.Text = "Door To Door Services";
            this.doortodoorBTN.UseVisualStyleBackColor = false;
            this.doortodoorBTN.Click += new System.EventHandler(this.doortodoorBTN_Click);
            // 
            // topParcelsBTN
            // 
            this.topParcelsBTN.BackColor = System.Drawing.Color.DimGray;
            this.topParcelsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.topParcelsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.topParcelsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topParcelsBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topParcelsBTN.Location = new System.Drawing.Point(273, 160);
            this.topParcelsBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topParcelsBTN.Name = "topParcelsBTN";
            this.topParcelsBTN.Size = new System.Drawing.Size(197, 98);
            this.topParcelsBTN.TabIndex = 9;
            this.topParcelsBTN.Text = "Top 5 by Parcels";
            this.topParcelsBTN.UseVisualStyleBackColor = false;
            this.topParcelsBTN.Click += new System.EventHandler(this.topParcelsBTN_Click);
            // 
            // NewestshipmentsBTN
            // 
            this.NewestshipmentsBTN.BackColor = System.Drawing.Color.DimGray;
            this.NewestshipmentsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewestshipmentsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewestshipmentsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewestshipmentsBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewestshipmentsBTN.Location = new System.Drawing.Point(24, 44);
            this.NewestshipmentsBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewestshipmentsBTN.Name = "NewestshipmentsBTN";
            this.NewestshipmentsBTN.Size = new System.Drawing.Size(197, 98);
            this.NewestshipmentsBTN.TabIndex = 6;
            this.NewestshipmentsBTN.Text = "Newest 5 Shipments";
            this.NewestshipmentsBTN.UseVisualStyleBackColor = false;
            this.NewestshipmentsBTN.Click += new System.EventHandler(this.NewestshipmentsBTN_Click);
            // 
            // providersLIST
            // 
            this.providersLIST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providersLIST.FormattingEnabled = true;
            this.providersLIST.ItemHeight = 20;
            this.providersLIST.Location = new System.Drawing.Point(11, 128);
            this.providersLIST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.providersLIST.Name = "providersLIST";
            this.providersLIST.Size = new System.Drawing.Size(257, 304);
            this.providersLIST.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 31;
            this.label1.Text = "Providers List";
            // 
            // sumofPandDBTN
            // 
            this.sumofPandDBTN.BackColor = System.Drawing.Color.DimGray;
            this.sumofPandDBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sumofPandDBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumofPandDBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumofPandDBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sumofPandDBTN.Location = new System.Drawing.Point(229, 20);
            this.sumofPandDBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sumofPandDBTN.Name = "sumofPandDBTN";
            this.sumofPandDBTN.Size = new System.Drawing.Size(168, 85);
            this.sumofPandDBTN.TabIndex = 0;
            this.sumofPandDBTN.Text = "Sum of Parcels and Docs";
            this.sumofPandDBTN.UseVisualStyleBackColor = false;
            this.sumofPandDBTN.Click += new System.EventHandler(this.sumofPandDBTN_Click);
            // 
            // NumofShipmentsBTN
            // 
            this.NumofShipmentsBTN.BackColor = System.Drawing.Color.DimGray;
            this.NumofShipmentsBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NumofShipmentsBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NumofShipmentsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumofShipmentsBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NumofShipmentsBTN.Location = new System.Drawing.Point(19, 20);
            this.NumofShipmentsBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumofShipmentsBTN.Name = "NumofShipmentsBTN";
            this.NumofShipmentsBTN.Size = new System.Drawing.Size(168, 85);
            this.NumofShipmentsBTN.TabIndex = 3;
            this.NumofShipmentsBTN.Text = "Show Shipments";
            this.NumofShipmentsBTN.UseVisualStyleBackColor = false;
            this.NumofShipmentsBTN.Click += new System.EventHandler(this.NumofShipmentsBTN_Click);
            // 
            // averageweightperproviderBTN
            // 
            this.averageweightperproviderBTN.BackColor = System.Drawing.Color.DimGray;
            this.averageweightperproviderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.averageweightperproviderBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.averageweightperproviderBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageweightperproviderBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.averageweightperproviderBTN.Location = new System.Drawing.Point(19, 124);
            this.averageweightperproviderBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.averageweightperproviderBTN.Name = "averageweightperproviderBTN";
            this.averageweightperproviderBTN.Size = new System.Drawing.Size(168, 85);
            this.averageweightperproviderBTN.TabIndex = 4;
            this.averageweightperproviderBTN.Text = "Average Shipments Weight";
            this.averageweightperproviderBTN.UseVisualStyleBackColor = false;
            this.averageweightperproviderBTN.Click += new System.EventHandler(this.averageweightperproviderBTN_Click);
            // 
            // maxweightBTN
            // 
            this.maxweightBTN.BackColor = System.Drawing.Color.DimGray;
            this.maxweightBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maxweightBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maxweightBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxweightBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxweightBTN.Location = new System.Drawing.Point(229, 124);
            this.maxweightBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxweightBTN.Name = "maxweightBTN";
            this.maxweightBTN.Size = new System.Drawing.Size(168, 85);
            this.maxweightBTN.TabIndex = 5;
            this.maxweightBTN.Text = "Max Weight";
            this.maxweightBTN.UseVisualStyleBackColor = false;
            this.maxweightBTN.Click += new System.EventHandler(this.maxweightBTN_Click);
            // 
            // totalshipmentsPriceBTN
            // 
            this.totalshipmentsPriceBTN.BackColor = System.Drawing.Color.DimGray;
            this.totalshipmentsPriceBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.totalshipmentsPriceBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalshipmentsPriceBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalshipmentsPriceBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalshipmentsPriceBTN.Location = new System.Drawing.Point(451, 24);
            this.totalshipmentsPriceBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalshipmentsPriceBTN.Name = "totalshipmentsPriceBTN";
            this.totalshipmentsPriceBTN.Size = new System.Drawing.Size(168, 85);
            this.totalshipmentsPriceBTN.TabIndex = 2;
            this.totalshipmentsPriceBTN.Text = "Total Shipments Prices";
            this.totalshipmentsPriceBTN.UseVisualStyleBackColor = false;
            this.totalshipmentsPriceBTN.Click += new System.EventHandler(this.totalshipmentsPriceBTN_Click);
            // 
            // shipmentsposteddatesBTN
            // 
            this.shipmentsposteddatesBTN.BackColor = System.Drawing.Color.DimGray;
            this.shipmentsposteddatesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shipmentsposteddatesBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shipmentsposteddatesBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipmentsposteddatesBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shipmentsposteddatesBTN.Location = new System.Drawing.Point(451, 124);
            this.shipmentsposteddatesBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmentsposteddatesBTN.Name = "shipmentsposteddatesBTN";
            this.shipmentsposteddatesBTN.Size = new System.Drawing.Size(168, 85);
            this.shipmentsposteddatesBTN.TabIndex = 1;
            this.shipmentsposteddatesBTN.Text = "Shipments Posted Dates";
            this.shipmentsposteddatesBTN.UseVisualStyleBackColor = false;
            this.shipmentsposteddatesBTN.Click += new System.EventHandler(this.shipmentsposteddatesBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.top5weightBTN);
            this.groupBox1.Controls.Add(this.topParcelsBTN);
            this.groupBox1.Controls.Add(this.samedayBTN);
            this.groupBox1.Controls.Add(this.doortodoorBTN);
            this.groupBox1.Controls.Add(this.NewestshipmentsBTN);
            this.groupBox1.Controls.Add(this.top5hishestpricesBTN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1025, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(497, 406);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Track";
            // 
            // TrackProvidersShipments
            // 
            this.TrackProvidersShipments.Controls.Add(this.sumofPandDBTN);
            this.TrackProvidersShipments.Controls.Add(this.NumofShipmentsBTN);
            this.TrackProvidersShipments.Controls.Add(this.shipmentsposteddatesBTN);
            this.TrackProvidersShipments.Controls.Add(this.averageweightperproviderBTN);
            this.TrackProvidersShipments.Controls.Add(this.totalshipmentsPriceBTN);
            this.TrackProvidersShipments.Controls.Add(this.maxweightBTN);
            this.TrackProvidersShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackProvidersShipments.Location = new System.Drawing.Point(293, 128);
            this.TrackProvidersShipments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrackProvidersShipments.Name = "TrackProvidersShipments";
            this.TrackProvidersShipments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrackProvidersShipments.Size = new System.Drawing.Size(644, 213);
            this.TrackProvidersShipments.TabIndex = 38;
            this.TrackProvidersShipments.TabStop = false;
            this.TrackProvidersShipments.Text = "TrackProvidersShipments";
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1524, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // Shipment_Tracker_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1524, 732);
            this.Controls.Add(this.TrackProvidersShipments);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.providersLIST);
            this.Controls.Add(this.QueryDiscriptionLBL);
            this.Controls.Add(this.shipmenttabledatagridview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Shipment_Tracker_Console";
            this.Text = "Shipment Tracker Console";
            this.Activated += new System.EventHandler(this.Shipment_Tracker_Console_Activated);
            this.Deactivate += new System.EventHandler(this.Shipment_Tracker_Console_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Shipment_Tracker_Console_FormClosed);
            this.Load += new System.EventHandler(this.Shipment_Tracker_Console_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.TrackProvidersShipments.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shipmenttabledatagridview;
        private SwiftTrackDataSet swiftTrackDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private SwiftTrackDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.Button top5weightBTN;
        private System.Windows.Forms.Label QueryDiscriptionLBL;
        private System.Windows.Forms.Button top5hishestpricesBTN;
        private System.Windows.Forms.Button samedayBTN;
        private System.Windows.Forms.Button doortodoorBTN;
        private System.Windows.Forms.Button topParcelsBTN;
        private System.Windows.Forms.Button NewestshipmentsBTN;
        public System.Windows.Forms.ListBox providersLIST;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sumofPandDBTN;
        private System.Windows.Forms.Button NumofShipmentsBTN;
        private System.Windows.Forms.Button averageweightperproviderBTN;
        private System.Windows.Forms.Button maxweightBTN;
        private System.Windows.Forms.Button totalshipmentsPriceBTN;
        private System.Windows.Forms.Button shipmentsposteddatesBTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox TrackProvidersShipments;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}