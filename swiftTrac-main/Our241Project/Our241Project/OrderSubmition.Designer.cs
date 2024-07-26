namespace Our241Project
{
    partial class OrderSubmition
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
            this.SubmitBTN = new System.Windows.Forms.Button();
            this.backBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.totpriceLBL = new System.Windows.Forms.Label();
            this.shipmenttabledatagridview = new System.Windows.Forms.DataGridView();
            this.shipmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shipmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parcelsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recieverAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.shipmentTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.ShipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // SubmitBTN
            // 
            this.SubmitBTN.BackColor = System.Drawing.Color.DimGray;
            this.SubmitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubmitBTN.Location = new System.Drawing.Point(445, 247);
            this.SubmitBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitBTN.Name = "SubmitBTN";
            this.SubmitBTN.Size = new System.Drawing.Size(209, 96);
            this.SubmitBTN.TabIndex = 0;
            this.SubmitBTN.Text = "Submit";
            this.SubmitBTN.UseVisualStyleBackColor = false;
            this.SubmitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.DimGray;
            this.backBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBTN.Location = new System.Drawing.Point(156, 247);
            this.backBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(209, 96);
            this.backBTN.TabIndex = 1;
            this.backBTN.Text = "Go back";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Order Submition";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.Black;
            this.lbl.Location = new System.Drawing.Point(143, 154);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(349, 41);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "The Total Price is :";
            // 
            // totpriceLBL
            // 
            this.totpriceLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totpriceLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totpriceLBL.ForeColor = System.Drawing.Color.Black;
            this.totpriceLBL.Location = new System.Drawing.Point(520, 154);
            this.totpriceLBL.Name = "totpriceLBL";
            this.totpriceLBL.Size = new System.Drawing.Size(131, 47);
            this.totpriceLBL.TabIndex = 16;
            this.totpriceLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.totalWeightDataGridViewTextBoxColumn,
            this.serviceTypeDataGridViewTextBoxColumn,
            this.postingDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.recieverZipDataGridViewTextBoxColumn,
            this.recieverAddressDataGridViewTextBoxColumn});
            this.shipmenttabledatagridview.DataSource = this.shipmentBindingSource;
            this.shipmenttabledatagridview.Location = new System.Drawing.Point(705, 404);
            this.shipmenttabledatagridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shipmenttabledatagridview.Name = "shipmenttabledatagridview";
            this.shipmenttabledatagridview.RowHeadersWidth = 51;
            this.shipmenttabledatagridview.RowTemplate.Height = 24;
            this.shipmenttabledatagridview.Size = new System.Drawing.Size(435, 182);
            this.shipmenttabledatagridview.TabIndex = 17;
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
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // OrderSubmition
            // 
            this.AcceptButton = this.SubmitBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.backBTN;
            this.ClientSize = new System.Drawing.Size(835, 383);
            this.Controls.Add(this.shipmenttabledatagridview);
            this.Controls.Add(this.totpriceLBL);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.SubmitBTN);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrderSubmition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSubmition";
            this.Activated += new System.EventHandler(this.OrderSubmition_Activated);
            this.Deactivate += new System.EventHandler(this.OrderSubmition_Deactivate);
            this.Load += new System.EventHandler(this.OrderSubmition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shipmenttabledatagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitBTN;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label totpriceLBL;
        private SwiftTrackDataSet swiftTrackDataSet;
        private SwiftTrackDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.DataGridView shipmenttabledatagridview;
        private System.Windows.Forms.BindingSource shipmentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parcelsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recieverAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
    }
}