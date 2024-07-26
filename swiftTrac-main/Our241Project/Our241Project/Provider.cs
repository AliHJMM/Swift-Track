using System;
using System.Drawing;
using System.Windows.Forms;

namespace Our241Project
{
    public partial class Provider : Form
    {

        
        public Provider()
        {
            InitializeComponent();
        }

        OrderSubmition orderSubmition = new OrderSubmition();
        Packaging packaging = new Packaging();
        private bool isClearButtonClicked = false;

        const decimal sameDayPrice = 5.28m, doorToDoor = 3.96m, international = 13.20m, domestic = 1.32m;

        private void Provider_Activated(object sender, EventArgs e)
        {
            
            this.BackColor = SystemColors.ActiveCaption;
            
        }

     

        

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
          this.Close();
        }

        private void Provider_FormClosed(object sender, FormClosedEventArgs e)
        {
            clearContolls();
        }

        private void Provider_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
          

        }

        private void Provider_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'swiftTrackDataSet.Shipment' table. You can move, or remove it, as needed.
            this.shipmentTableAdapter.Fill(this.swiftTrackDataSet.Shipment);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult clearinfo;
                clearinfo = MessageBox.Show("Are you Sure you Want To clear All This Information?!", "Clear Form Controls",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (clearinfo == DialogResult.Yes)
                {
                    clearContolls();
                }
                else
                {
                    MessageBox.Show("OK Sir Continue", "Clear Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Provider_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && isClearButtonClicked)
            {
                e.Cancel = true;
                isClearButtonClicked = false;
            }
        }
        private void submitBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string providerName = providerfullnameTXT.Text;
                string providerPhone = providerphonenumberTXT.Text;
                string providerAddress = provideraddressTXT.Text;
                string providerZip = providerzipTXT.Text;
                string providerCity = providercountryTXT.Text;

                string recieverName = recieverfullnameTXT.Text;
                string recieverPhone = recieverphonenumberTXT.Text;
                string recieverAddress = recieveraddressTXT.Text;
                string recieverZip = recieverzipTXT.Text;
                string recieverCity = recievercountryTXT.Text;

                decimal weight;
                int numberOfparcels;
                int numberOfDocs;
                string serviceType;
                decimal totalPrice = 0m;

                if (providerName != "")
                {
                    if (providerPhone != "")
                    {
                        if (providerAddress != "")
                        {
                            if (providerZip != "")
                            {
                                if (providerCity != "")
                                {
                                    if (recieverName != "")
                                    {
                                        if (recieverPhone != "")
                                        {
                                            if (recieverAddress != "")
                                            {
                                                if (recieverZip != "")
                                                {
                                                    if (recieverCity != "")
                                                    {
                                                        if (decimal.TryParse(weightTXT.Text, out weight))
                                                        {
                                                            if (int.TryParse(parcelsTXT.Text, out numberOfparcels))
                                                            {
                                                                if (int.TryParse(docsTXT.Text, out numberOfDocs))
                                                                {
                                                                    if (servicesCOMBOBOX.SelectedIndex != -1)
                                                                    {
                                                                        serviceType = servicesCOMBOBOX.SelectedItem.ToString();
                                                                        if (internationalRAD.Checked || domesticRAD.Checked)
                                                                        {
                                                                            if (confirmationCHECKBOX.Checked)
                                                                            {
                                                                                if (servicesCOMBOBOX.SelectedIndex == 0)
                                                                                {
                                                                                    totalPrice += weight * sameDayPrice;
                                                                                }
                                                                                else if (servicesCOMBOBOX.SelectedIndex == 1)
                                                                                {
                                                                                    totalPrice += weight * doorToDoor;
                                                                                }
                                                                                if (internationalRAD.Checked)
                                                                                {
                                                                                    totalPrice += weight * international;
                                                                                }
                                                                                else if (domesticRAD.Checked)
                                                                                {
                                                                                    totalPrice += weight * domestic;
                                                                                }

                                                                                packaging.providerName = providerName;
                                                                                packaging.providerPhone = providerPhone;
                                                                                packaging.providerAddress = providerAddress;
                                                                                packaging.providerZip = providerZip;
                                                                                packaging.providerCity = providerCity;
                                                                                packaging.recieverName = recieverfullnameTXT.Text;
                                                                                packaging.recieverPhone = recieverName;
                                                                                packaging.recieverAddress = recieverAddress;
                                                                                packaging.recieverZip = recieverZip;
                                                                                packaging.recieverCity = recieverCity;
                                                                                packaging.weight = weight;
                                                                                packaging.numberOfparcels = numberOfparcels;
                                                                                packaging.numberOfDocs = numberOfDocs;
                                                                                packaging.serviceType = serviceType;
                                                                                packaging.totalPrice = totalPrice;
                                                                                packaging.ShowDialog();

                                                                                if (packaging.close)
                                                                                {
                                                                                    this.Close();
                                                                                    
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("The Confirmation is missing", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                                confirmationCHECKBOX.Focus();
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Select if it's international or domestic", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Select a service type", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                        servicesCOMBOBOX.Focus();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Invalid Number Of Documents", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                    docsTXT.Focus();
                                                                    docsTXT.SelectAll();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Invalid Number Of Parcel", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                parcelsTXT.Focus();
                                                                parcelsTXT.SelectAll();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Invalid Weight", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                            weightTXT.Focus();
                                                            weightTXT.SelectAll();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Please Enter Receiver City", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        recievercountryTXT.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Please Enter Receiver Zip", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    recieverzipTXT.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Enter Receiver Address", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                recieveraddressTXT.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Please Enter Receiver Phone Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            recieverphonenumberTXT.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Enter Receiver Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        recieverfullnameTXT.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Enter Provider City", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    providercountryTXT.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Enter Provider Zip", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                providerzipTXT.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Provider Address", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            provideraddressTXT.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Provider Phone Number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        providerphonenumberTXT.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Provider Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    providerfullnameTXT.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           private void clearContolls()
        {
            providerfullnameTXT.Clear();
            providerphonenumberTXT.Clear();
            provideraddressTXT.Clear();
            providerzipTXT.Clear();
            providercountryTXT.Clear();
            recieverfullnameTXT.Clear();
            recieverphonenumberTXT.Clear();
            recieveraddressTXT.Clear();
            recieverzipTXT.Clear();
            recievercountryTXT.Clear();
            weightTXT.Clear();
            parcelsTXT.Clear();
            docsTXT.Clear();
            internationalRAD.Checked = false;
            domesticRAD.Checked = false;
            confirmationCHECKBOX.Checked = false;
            servicesCOMBOBOX.SelectedIndex = -1; 
        }
    }
}