using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Our241Project
{
    public partial class OrderSubmition : Form
    {
        public string providerName;
        public string providerPhone;
        public string providerAddress;
        public string providerZip;
        public string providerCity;

        public string recieverName;
        public string recieverPhone;
        public string recieverAddress;
        public string recieverZip;
        public string recieverCity;

        public decimal weight;
        public int numberOfparcels;
        public int numberOfDocs;
        public string serviceType;
        public decimal totalPrice = 0m;

        int courierId;

        Random rand = new Random();
        
        public OrderSubmition()
        {
            InitializeComponent();
            
        }
        
        
        
        
       public bool close = false;
        

        private void OrderSubmition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swiftTrackDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.swiftTrackDataSet.Shipment);
            totpriceLBL.Text = totalPrice.ToString("c2");


        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            close = false;
            this.Close();
           

        }
        private bool IsShipmentIdExists(int shipmentID)
        {
            return swiftTrackDataSet.Shipment.Rows.Find(shipmentID) != null;
        }

        private void SubmitBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                int shipmentID ;
                courierId = rand.Next(1,13);
                do
                {
                    shipmentID = rand.Next(10000, 100000);
                } while (IsShipmentIdExists(shipmentID));

                SwiftTrackDataSet.ShipmentRow row;
                row = swiftTrackDataSet.Shipment.NewShipmentRow();
                row.shipmentID = shipmentID;
                row.courierID = courierId;
                row.providerName = providerName;
                row.recieverAddress = recieverAddress;
                row.postingDate = currentDate.ToString("MM/dd/yyyy");
                row.recieverName= recieverName;
                row.price = totalPrice;
                row.parcels = numberOfparcels;
                row.documents = numberOfDocs;
                row.totalWeight = weight;
                row.serviceType = serviceType;
                row.recieverZip= recieverZip;
                swiftTrackDataSet.Shipment.Rows.Add(row);
                shipmentBindingSource.EndEdit();
                shipmentTableAdapter.Update(swiftTrackDataSet.Shipment);

                MessageBox.Show("Your order is successfully Submited \n" +
                    "The shipment Id: "+shipmentID+"  will be sent to the reciever ", "Order Submition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                close = true;
                this.Close();   
                
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderSubmition_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void OrderSubmition_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }
    }
}
