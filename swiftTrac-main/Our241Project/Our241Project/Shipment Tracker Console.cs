using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Our241Project
{
    public partial class Shipment_Tracker_Console : Form
    {
        public Shipment_Tracker_Console()
        {
            InitializeComponent();
        }

        private void top5weight_Click(object sender, EventArgs e)
        {
            shipmentTableAdapter.Top5Weight(swiftTrackDataSet.Shipment);
            QueryDiscriptionLBL.Text = "These are The Highest Weight Top 5 Shipments";
        }

        private void top5hishestprices_Click(object sender, EventArgs e)
        {
            shipmentTableAdapter.Top5Prices(swiftTrackDataSet.Shipment);
            QueryDiscriptionLBL.Text = "These are The Top 5 Shipments With Highest Prices";
        }

        private void samedayBTN_Click(object sender, EventArgs e)
        {
            shipmentTableAdapter.SameDayServices(swiftTrackDataSet.Shipment);
            QueryDiscriptionLBL.Text = "These are All Same Day Shipments That We Have";

        }

        private void doortodoorBTN_Click(object sender, EventArgs e)
        {
            shipmentTableAdapter.DoortoDoor(swiftTrackDataSet.Shipment);
            QueryDiscriptionLBL.Text = "These are All Door to Door Shipments That We Have";
        }

        private void Shipment_Tracker_Console_Load(object sender, EventArgs e)
        {
            shipmentTableAdapter.Fill(swiftTrackDataSet.Shipment);
        }

        private void topParcelsBTN_Click(object sender, EventArgs e)
        {
            shipmentTableAdapter.Top5parcels(swiftTrackDataSet.Shipment);
            QueryDiscriptionLBL.Text = "These Are The Top 5 Shipments By Number of Parcels";
        }

        private void NewestshipmentsBTN_Click(object sender, EventArgs e)
        {
            shipmentTableAdapter.NewestShipments(swiftTrackDataSet.Shipment);
            QueryDiscriptionLBL.Text = "These Are The Latest 5 Posted Shipments";

        }

        private void sumofPandDBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (providersLIST.SelectedIndex != -1)
                {
                 string provider=providersLIST.SelectedItem.ToString();
                     int sumofParcel =(int)shipmentTableAdapter.SumOfparcelsPerProvider(provider);
                    int sumofDocs = (int)shipmentTableAdapter.SumofDocsPerProvider(provider);
                    QueryDiscriptionLBL.Text = "The Poster " + provider + " Has a Total Sum of " + sumofParcel + " Parcels and Total Sum of " +
                        sumofDocs+" Documents";
                    MessageBox.Show("The Poster " + provider + " Has a Total Sum of " + sumofParcel + " Parcels and Total sum of "+sumofDocs+
                        " Documents", "Sum of Parcels And Docs  ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else {
                    MessageBox.Show("Select a Provider First","Missing Provider", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumofShipmentsBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (providersLIST.SelectedIndex != -1)
                {
                    int totalshipments = 0;
                    string provider = providersLIST.SelectedItem.ToString();
                    totalshipments=(int)shipmentTableAdapter.totalShipmentsPerProvider(provider);
                    shipmentTableAdapter.ShowShipmentByProvider(swiftTrackDataSet.Shipment,provider);
                    QueryDiscriptionLBL.Text = "The number of Shipments By The Poster "+provider+" is "+totalshipments;

                }

                else
                {
                    MessageBox.Show("Select a Provider First", "Missing Provider", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void averageweightperproviderBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (providersLIST.SelectedIndex != -1)
                {
                    string provider = providersLIST.SelectedItem.ToString();
                    decimal Avgweight = (decimal)shipmentTableAdapter.AverageweigthPerProvider(provider);
                    QueryDiscriptionLBL.Text ="The Average Shipments Total Weight of the Poster "+provider+" is "+Avgweight.ToString("n2") + " KG";
                    MessageBox.Show("The Average Shipments Total Weight of The Poster " + provider + " is " + Avgweight.ToString("n2")+" KG"
                     , "AVG Weight Per Provider", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select a Provider First", "Missing Provider", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maxweightBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (providersLIST.SelectedIndex != -1)
                {
                    string provider = providersLIST.SelectedItem.ToString();
                    decimal maxweight = (decimal)shipmentTableAdapter.MaxweightPerProvider(provider);
                    MessageBox.Show("The Shipment With Max Weight for the Poster " + provider + " is " + maxweight.ToString("n2") + " KG"
                     , "Max Weight Per Provider", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Select a Provider First", "Missing Provider", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void totalshipmentsPriceBTN_Click(object sender, EventArgs e)
        {
            if (providersLIST.SelectedIndex != -1)
            {
                string provider = providersLIST.SelectedItem.ToString();
                decimal totprices = (decimal)shipmentTableAdapter.TotalShipmentsPricePerProvider(provider);
                MessageBox.Show("The Shipments Total Price For The Poster " + provider + " is " + totprices.ToString("c2")
                 , "Total Shipments Price Per Provider", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QueryDiscriptionLBL.Text= "The Shipments Total Price For The Poster " + provider + " is " + totprices.ToString("c2");

            }
            else
            {
                MessageBox.Show("Select a Provider First", "Missing Provider", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void shipmentsposteddatesBTN_Click(object sender, EventArgs e)
        {
            shipmentTableAdapter.Fill(swiftTrackDataSet.Shipment);
            try
            {
                if (providersLIST.SelectedIndex != -1)
                {
                    SwiftTrackDataSet.ShipmentRow ROW;
                    
                    string provider = providersLIST.SelectedItem.ToString();
                    int count = (int)shipmentTableAdapter.count();
                    List<string> messageList = new List<string>();
                    int foundcount = 1;
                    for (int i = 0; i < count; i++)
                    {
                        ROW = swiftTrackDataSet.Shipment[i];
                        if (ROW.providerName == provider)
                        {
                            messageList.Add("The Posted Date of The " + foundcount + " Shipment For " + provider + " is " + ROW.postingDate.ToString());
                            foundcount++; 
                        }

                        }
                    string dateMessage = "";
                    foreach (string s in messageList )
                    {
                        dateMessage+= s+"\n";

                        QueryDiscriptionLBL.Text = s + "\n";

                    }
                    MessageBox.Show(dateMessage, "Shipment Posted Dates", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Select a Provider First", "Missing Provider", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Shipment_Tracker_Console_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Shipment_Tracker_Console_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shipment_Tracker_Console_FormClosed(object sender, FormClosedEventArgs e)
        {
            providersLIST.Items.Clear();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
