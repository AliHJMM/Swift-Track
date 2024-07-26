namespace Our241Project
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.rownumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swiftTrackDataSet = new Our241Project.SwiftTrackDataSet();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.shipmentTableAdapter = new Our241Project.SwiftTrackDataSetTableAdapters.ShipmentTableAdapter();
            this.load = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.maxPriceLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxWeightLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.recieverAddressDataGridViewTextBoxColumn,
            this.rownumber});
            this.dataGridView1.DataSource = this.shipmentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 429);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(915, 141);
            this.dataGridView1.TabIndex = 0;
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
            // rownumber
            // 
            this.rownumber.DataPropertyName = "rownumber";
            this.rownumber.HeaderText = "rownumber";
            this.rownumber.MinimumWidth = 6;
            this.rownumber.Name = "rownumber";
            this.rownumber.Visible = false;
            this.rownumber.Width = 125;
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(257, 31);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Shipment price";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(648, 328);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // shipmentTableAdapter
            // 
            this.shipmentTableAdapter.ClearBeforeFill = true;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.DimGray;
            this.load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.load.Location = new System.Drawing.Point(508, 375);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(131, 40);
            this.load.TabIndex = 0;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Of Prices:";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(141, 59);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(2, 22);
            this.totalLbl.TabIndex = 4;
            // 
            // maxPriceLbl
            // 
            this.maxPriceLbl.AutoSize = true;
            this.maxPriceLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxPriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPriceLbl.Location = new System.Drawing.Point(141, 96);
            this.maxPriceLbl.Name = "maxPriceLbl";
            this.maxPriceLbl.Size = new System.Drawing.Size(2, 22);
            this.maxPriceLbl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Price:";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.countLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.Location = new System.Drawing.Point(141, 171);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(2, 22);
            this.countLbl.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Shipments:";
            // 
            // maxWeightLbl
            // 
            this.maxWeightLbl.AutoSize = true;
            this.maxWeightLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxWeightLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxWeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxWeightLbl.Location = new System.Drawing.Point(141, 134);
            this.maxWeightLbl.Name = "maxWeightLbl";
            this.maxWeightLbl.Size = new System.Drawing.Size(2, 22);
            this.maxWeightLbl.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max weight:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AcceptButton = this.load;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 570);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxWeightLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maxPriceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.load);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.Deactivate += new System.EventHandler(this.Dashboard_Deactivate);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swiftTrackDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private SwiftTrackDataSet swiftTrackDataSet;
        private System.Windows.Forms.BindingSource shipmentBindingSource;
        private SwiftTrackDataSetTableAdapters.ShipmentTableAdapter shipmentTableAdapter;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label maxPriceLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label countLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maxWeightLbl;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn rownumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}