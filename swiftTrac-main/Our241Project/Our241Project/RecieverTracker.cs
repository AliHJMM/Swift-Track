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
    public partial class RecieverTracker : Form
    {
        public RecieverTracker()
        {
            InitializeComponent();
        }
        Random ran = new Random();
        DateTime currentdate = DateTime.Now;
        private void trackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int ShipmentId = 0;
                if (int.TryParse(shipmentIdTxt.Text,out ShipmentId))
                {
                    
                    SwiftTrackDataSet.ShipmentRow row = swiftTrackDataSet.Shipment.FindByshipmentID(ShipmentId);
                    int courierId = row.courierID;
                    SwiftTrackDataSet.CourierRow row2 = swiftTrackDataSet.Courier.FindBycourierID(courierId);
                    decimal weight = row.totalWeight;
                    string deliverydate = row.postingDate;
                    string courierName = row2.fullName;
                    string courierNumber = row2.phoneNumber;
                    string servicetype = row.serviceType;
                    if(servicetype== "Door to Door Services")
                    {
                        int days=ran.Next(1,11);
                       deliverydate= currentdate.AddDays(days).ToString("MM-dd-yyyy");
                    }

                    CourierNameTxt.Text = courierName;
                    courierNumberTxt.Text = courierNumber;
                    weightTxt.Text = weight.ToString() +"KG";
                    dateTxt.Text = deliverydate;

                    groupBox1.Show();
                }
                else
                {
                    MessageBox.Show("Please enter your shipment id","Input Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("The shipment ID is not available please check again or ask the poster",
                    "Incorrect shipment ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecieverTracker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swiftTrackDataSet.Courier' table. You can move, or remove it, as needed.
            this.courierTableAdapter.Fill(this.swiftTrackDataSet.Courier);
            // TODO: This line of code loads data into the 'swiftTrackDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.swiftTrackDataSet.Shipment);

        }

        private void RecieverTracker_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void RecieverTracker_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void RecieverTracker_FormClosed(object sender, FormClosedEventArgs e)
        {
            shipmentIdTxt.Text = string.Empty;
            groupBox1.Visible = false;
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
