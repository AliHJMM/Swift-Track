using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our241Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
       

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swiftTrackDataSet.Shipment' table. You can move, or remove it, as needed.
            shipmentTableAdapter.Fill(swiftTrackDataSet.Shipment);
            try
            {
                int rowCount = (int)shipmentTableAdapter.count();
                SwiftTrackDataSet.ShipmentRow row;
                for (int i = 0; i < rowCount; i++)
                {
                    row = swiftTrackDataSet.Shipment[i];
                    row.rownumber = i+1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void load_Click(object sender, EventArgs e)
        {
            try
            {
                chart1.Series[0].XValueMember = "rownumber";
                chart1.Series[0].YValueMembers = "price";
                chart1.DataSource = swiftTrackDataSet.Shipment;
                chart1.DataBind();


                decimal totalprices, maxprice, maxweight;int shipmentscount;
                totalprices = (decimal)shipmentTableAdapter.sum();
                maxprice = (decimal)shipmentTableAdapter.maxPrice();
                maxweight = (decimal)shipmentTableAdapter.maxWeight();
                shipmentscount=(int)shipmentTableAdapter.count();
                totalLbl.Text = totalprices.ToString("c2");
                maxPriceLbl.Text = maxprice.ToString("c2");
                maxWeightLbl.Text = maxweight.ToString("n2");
                countLbl.Text = shipmentscount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Dashboard_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
