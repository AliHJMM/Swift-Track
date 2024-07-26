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
    public partial class ShipmentModifier : Form
    {
        public ShipmentModifier()
        {
            InitializeComponent();
        }
        
        private void Shipment_Modifier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swiftTrackDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.swiftTrackDataSet.Shipment);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

       
        private void retrieveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (shipmenttabledatagridview.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = shipmenttabledatagridview.SelectedRows[0];
                    shipmentIDTXT.Text = selectedRow.Cells["shipmentID"].Value.ToString();
                    courierIDTXT.Text = selectedRow.Cells["courierID"].Value.ToString();
                    providerfullnameTXT.Text= selectedRow.Cells["providerName"].Value.ToString();
                    recieverfullnameTXT.Text= selectedRow.Cells["recieverName"].Value.ToString();
                    parcelsTXT.Text= selectedRow.Cells["parcels"].Value.ToString();
                    docsTXT.Text= selectedRow.Cells["documents"].Value.ToString();
                    weightTXT.Text= selectedRow.Cells["totalWeight"].Value.ToString();
                    servicetypeTXT.Text= selectedRow.Cells["serviceType"].Value.ToString();
                    postingdateTXT.Text= selectedRow.Cells["postingDate"].Value.ToString();
                    priceTXT.Text= selectedRow.Cells["price"].Value.ToString();
                    recieverzipTXT.Text= selectedRow.Cells["recieverZip"].Value.ToString();
                    recieveraddressTXT.Text= selectedRow.Cells["recieverAddress"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Please select a row ", "Missing Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
                try
                {
                    if (shipmenttabledatagridview.SelectedRows.Count > 0)
                    {
                    DialogResult Change;
                    Change=MessageBox.Show("Are You Sure You Want to change The Shipment Info?","Modify",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (Change == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = shipmenttabledatagridview.SelectedRows[0];
                        selectedRow.Cells["shipmentID"].Value = shipmentIDTXT.Text;
                        selectedRow.Cells["courierID"].Value = courierIDTXT.Text;
                        selectedRow.Cells["providerName"].Value = providerfullnameTXT.Text;
                        selectedRow.Cells["recieverName"].Value = recieverfullnameTXT.Text;
                        selectedRow.Cells["parcels"].Value = parcelsTXT.Text;
                        selectedRow.Cells["documents"].Value = docsTXT.Text;
                        selectedRow.Cells["totalWeight"].Value = weightTXT.Text;
                        selectedRow.Cells["serviceType"].Value = servicetypeTXT.Text;
                        selectedRow.Cells["postingDate"].Value = postingdateTXT.Text;
                        selectedRow.Cells["price"].Value = priceTXT.Text;
                        selectedRow.Cells["recieverZip"].Value = recieverzipTXT.Text;
                        selectedRow.Cells["recieverAddress"].Value = recieveraddressTXT.Text;
                        shipmenttabledatagridview.Refresh();
                        shipmentBindingSource.EndEdit();
                        shipmentTableAdapter.Update(swiftTrackDataSet.Shipment);
                    }

                   
                   
                }
                    else
                    {
                        MessageBox.Show("Please select a row to update.", "Missing Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearControls();
        }
        private void clearControls()
        {
            shipmentIDTXT.Clear();
            courierIDTXT.Clear();
            providerfullnameTXT.Clear();
            recieverfullnameTXT.Clear();
            postingdateTXT.Clear();
            priceTXT.Clear();
            recieveraddressTXT.Clear();
            recieverzipTXT.Clear();
            parcelsTXT.Clear();
            docsTXT.Clear();
            weightTXT.Clear();
            servicetypeTXT.Clear();
            shipmenttabledatagridview.ClearSelection();
        }

        private void ShipmentModifier_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void ShipmentModifier_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void ShipmentModifier_FormClosed(object sender, FormClosedEventArgs e)
        {
            clearControls();
        }
    }
    }

