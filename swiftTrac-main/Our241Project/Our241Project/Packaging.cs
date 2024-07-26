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
    public partial class Packaging : Form
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
        decimal packagingPrice = 0;
        public bool close = false;
        bool isClosing =false;
        public Packaging()
        {
            InitializeComponent();
        }
        OrderSubmition orderSubmition = new OrderSubmition();  
       
        const decimal woodedcratespriceperKG = 2m, palletizationpriceperkg = 1.5m, baggedcargopriceperkg = 1.2m, fiberbroadboxpriceperkg = 0.8m
            ,cottonbalepriceperkh=0.5m;

        private void woodPIC_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Packaging_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;

        }

        private void Packaging_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;

        }

        private void Packaging_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosing = true;
            packageLISTBOX.SelectedIndex = -1;
            palletizationPIC.Visible = false;
            bagedPIC.Visible = false;
            fiberPIC.Visible = false;
            cottonPIC.Visible = false;
            woodPIC.Visible = false;
            packagingpriceTXT.Clear();
        }

        private void packageLISTBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((packageLISTBOX.SelectedIndex != -1) )
                {
                    switch (packageLISTBOX.SelectedIndex)
                    {
                        case 0:
                            packagingPrice = weight * woodedcratespriceperKG;
                            palletizationPIC.Visible = false;
                            bagedPIC.Visible = false;   
                            fiberPIC.Visible = false;
                            cottonPIC.Visible = false;
                            woodPIC.Visible = true;
                            break;
                        case 1:
                            packagingPrice = weight * palletizationpriceperkg;
                            palletizationPIC.Visible = true;
                            bagedPIC.Visible = false;
                            fiberPIC.Visible = false;
                            cottonPIC.Visible = false;
                            woodPIC.Visible = false;
                            break;
                        case 2:
                            packagingPrice = weight * baggedcargopriceperkg;
                            palletizationPIC.Visible = false;
                            bagedPIC.Visible = true;
                            fiberPIC.Visible = false;
                            cottonPIC.Visible = false;
                            woodPIC.Visible = false;
                            break;

                        case 3:
                            packagingPrice = weight * fiberbroadboxpriceperkg;
                            palletizationPIC.Visible = false;
                            bagedPIC.Visible = false;
                            fiberPIC.Visible = true;
                            cottonPIC.Visible = false;
                            woodPIC.Visible = true;
                            break;
                        case 4:
                            packagingPrice = weight * cottonbalepriceperkh;
                            palletizationPIC.Visible = false;
                            bagedPIC.Visible = false;
                            fiberPIC.Visible = false;
                            cottonPIC.Visible = true;
                            woodPIC.Visible = true;
                            break;
                        default:
                            packagingPrice = 0; break;
                    }
                    
                    packagingpriceTXT.Text = packagingPrice.ToString("c2");

                }
                else
                {
                    if (!isClosing)
                    {
                        MessageBox.Show("Select a packaging type", "Missing Packaging type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void totalweigthTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Packaging_Load(object sender, EventArgs e)
        {
            decimal totweight = orderSubmition.weight;
            totalweigthTXT.Text=weight.ToString("n2")+" KG";
            isClosing = false ;
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (packageLISTBOX.SelectedIndex != -1)
                {
                    orderSubmition.providerName = providerName;
                    orderSubmition.providerPhone = providerPhone;
                    orderSubmition.providerAddress = providerAddress;
                    orderSubmition.providerZip = providerZip;
                    orderSubmition.providerCity = providerCity;
                    orderSubmition.recieverName = recieverName;
                    orderSubmition.recieverPhone = recieverName;
                    orderSubmition.recieverAddress = recieverAddress;
                    orderSubmition.recieverZip = recieverZip;
                    orderSubmition.recieverCity = recieverCity;
                    orderSubmition.weight = weight;
                    orderSubmition.numberOfparcels = numberOfparcels;
                    orderSubmition.numberOfDocs = numberOfDocs;
                    orderSubmition.serviceType = serviceType;
                    orderSubmition.totalPrice = totalPrice + packagingPrice;
                    orderSubmition.ShowDialog();
                    this.close = orderSubmition.close;
                    if (orderSubmition.close)
                    {
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Select a packaging type", "Missing Packaging type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
