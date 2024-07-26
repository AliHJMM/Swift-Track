using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Our241Project
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        Random rand = new Random();
        Shipment_Tracker_Console shipmenttracker = new Shipment_Tracker_Console();
        ShipmentModifier shipmentModifier=new ShipmentModifier();
       

        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swiftTrackDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.swiftTrackDataSet.Shipment);
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            try
            {
                shipmentBindingSource.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nextBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                shipmentBindingSource.MoveNext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void previousBTN_Click(object sender, EventArgs e)
        {
            try
            {
                shipmentBindingSource.MovePrevious();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lastBTN_Click(object sender, EventArgs e)
        {
            try
            {
                shipmentBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void firstBTN_Click(object sender, EventArgs e)
        {
            try
            {
                shipmentBindingSource.MoveFirst();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                shipmentBindingSource.EndEdit();
                shipmentTableAdapter.Update(swiftTrackDataSet.Shipment);
                MessageBox.Show("Successfully Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult delete;
                delete = MessageBox.Show("Are You Sure You Want To Delete This?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(delete == DialogResult.Yes)
                {
                    int shipmentid;
                    if (int.TryParse(shipmentidTXT.Text, out shipmentid))
                    {
                        SwiftTrackDataSet.ShipmentRow row = swiftTrackDataSet.Shipment.FindByshipmentID(shipmentid);

                        if (row != null)
                        {
                            row.Delete();





                            MessageBox.Show("Successfully deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Shipment ID not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Shipment ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int parcels, documents; decimal weight, price;
                int courierID = rand.Next(1, 13);
                if (providerfullnameTXT.Text != "")
                {
                    if (recieverfullnameTXT.Text != "")
                    {
                        if (postingdateTXT.Text != "")
                        {
                            if (recieverzipTXT.Text != "")
                            {
                                if (servicetypeTXT.Text != "")
                                {
                                    if (recieveraddressTXT.Text != "")
                                    {
                                        if (int.TryParse(parcelsTXT.Text, out parcels))
                                        {
                                            if (int.TryParse(docsTXT.Text, out documents))
                                            {
                                                if (decimal.TryParse(priceTXT.Text, out price))
                                                {
                                                    if (decimal.TryParse(weightTXT.Text, out weight))
                                                    {
                                                        int shipmentID;
                                                        do
                                                        {
                                                            shipmentID = rand.Next(10000, 100000);
                                                        } while (IsShipmentIdExists(shipmentID));
                                                        SwiftTrackDataSet.ShipmentRow row;

                                                        row = swiftTrackDataSet.Shipment.NewShipmentRow();
                                                        row.shipmentID = shipmentID;
                                                        row.courierID = courierID;
                                                        row.providerName = providerfullnameTXT.Text;
                                                        row.recieverName = recieverfullnameTXT.Text;
                                                        row.price = price;
                                                        row.parcels = parcels;
                                                        row.documents = documents;
                                                        row.recieverZip = recieverzipTXT.Text;
                                                        row.recieverAddress = recieveraddressTXT.Text;
                                                        row.serviceType = servicetypeTXT.Text;
                                                        row.totalWeight = weight;
                                                        row.postingDate = postingdateTXT.Text;
                                                        swiftTrackDataSet.Shipment.Rows.Add(row);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Invalid weight input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        weightTXT.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Invalid price input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    priceTXT.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid documents input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                docsTXT.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid parcels input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            parcelsTXT.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter reciever address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        recieveraddressTXT.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter servicetype", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    servicetypeTXT.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter reciever zip", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                recieverzipTXT.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter posting date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            postingdateTXT.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter reciever name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        recieverfullnameTXT.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter provider name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    providerfullnameTXT.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void recievelbl_Click(object sender, EventArgs e)
        {

        }
        private bool IsShipmentIdExists(int shipmentID)
        {
            return swiftTrackDataSet.Shipment.Rows.Find(shipmentID) != null;
        }
        private void insertBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int parcels, documents; decimal weight, price;
                int courierID = rand.Next(1, 13);
                MessageBox.Show("" + courierID);
                int shipmentID;

                if (providerfullnameTXT.Text != "")
                {
                    if (recieverfullnameTXT.Text != "")
                    {
                        if (postingdateTXT.Text != "")
                        {
                            if (recieverzipTXT.Text != "")
                            {
                                if (servicetypeTXT.Text != "")
                                {
                                    if (recieveraddressTXT.Text != "")
                                    {
                                        if (int.TryParse(parcelsTXT.Text, out parcels))
                                        {
                                            if (int.TryParse(docsTXT.Text, out documents))
                                            {
                                                if (decimal.TryParse(priceTXT.Text, out price))
                                                {
                                                    if (decimal.TryParse(weightTXT.Text, out weight))
                                                    {
                                                        do
                                                        {
                                                            shipmentID = rand.Next(10000, 100000);
                                                        } while (IsShipmentIdExists(shipmentID));
                                                        shipmentTableAdapter.Insert(courierID, providerfullnameTXT.Text, recieverfullnameTXT.Text, parcels, documents, weight,
                                                            servicetypeTXT.Text, postingdateTXT.Text, price, recieveraddressTXT.Text, recieverzipTXT.Text, shipmentID,0);
                                                        shipmentTableAdapter.Fill(swiftTrackDataSet.Shipment);
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Invalid weight input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        weightTXT.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Invalid price input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    priceTXT.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Invalid documents input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                docsTXT.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Invalid parcels input", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            parcelsTXT.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please enter reciever address", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        recieveraddressTXT.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please enter servicetype", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    servicetypeTXT.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter reciever zip", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                recieverzipTXT.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please enter posting date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            postingdateTXT.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter reciever name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        recieverfullnameTXT.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter provider name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    providerfullnameTXT.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void DeleBTN_Click(object sender, EventArgs e)
        {
            try {
                if (shipmenttabledatagridview.SelectedRows.Count>0)
                {
                    // Prompt the user for confirmation
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        DataGridViewRow selectedRow = shipmenttabledatagridview.SelectedRows[0];
                        shipmenttabledatagridview.Rows.Remove(selectedRow);  
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Missing Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void trackerConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SwiftTrackDataSet.ShipmentRow rw;
                int rows = (int)shipmentTableAdapter.count();
                rw = swiftTrackDataSet.Shipment[0];
                for (int i = 0; i < rows; i++)
                {
                    if(!shipmenttracker.providersLIST.Items.Contains(rw.providerName))
                    {
                        shipmenttracker.providersLIST.Items.Add(rw.providerName);
                    }
                    

                    if (i < rows - 1)
                    {
                        rw = swiftTrackDataSet.Shipment[i + 1];
                    }
                }

                shipmenttracker.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Administrator_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
        }

        private void Administrator_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
                DialogResult exit;
                exit = MessageBox.Show("Are You Sure You Want To Exit Boss ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (exit == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Ok Continue Working Boss", "Exit Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
        }

        private void Administrator_FormClosed(object sender, FormClosedEventArgs e)
        {
            clearTextBox();
        }
        private void clearTextBox()
        {
            providerfullnameTXT.Clear();
            recieverfullnameTXT.Clear();
            parcelsTXT.Clear();
            docsTXT.Clear();
            postingdateTXT.Clear();
            priceTXT.Clear();
            recieverzipTXT.Clear();
            weightTXT.Clear();
            servicetypeTXT.Clear(); 
            recieveraddressTXT.Clear();
            shipmentidTXT.Clear();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DialogResult clear;
            clear = MessageBox.Show("Are You sure You Want To Clear All Informations?","Clear" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (clear== DialogResult.Yes)
            {
                clearTextBox();
            }
            
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shipmentModifier.ShowDialog();
            this.shipmentTableAdapter.Fill(this.swiftTrackDataSet.Shipment);
        }


    } 
    }
    
