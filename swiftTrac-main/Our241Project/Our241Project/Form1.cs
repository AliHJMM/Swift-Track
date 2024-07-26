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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RecieverTracker Reciever = new RecieverTracker();
        Provider_Account provideraccount =new Provider_Account();
        Login login = new Login();
        AboutForm AboutForm = new AboutForm();  
       

        private void Form1_Load(object sender, EventArgs e)
        {
            ourToolTip.SetToolTip(providerBTN, "Post Your Shipment");
            ourToolTip.SetToolTip(recieverBTN, "Track Your Shipment");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            provideraccount.ShowDialog();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            Reciever.ShowDialog();
        }

        

        private void providerBTN_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;
          
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult close;
            close = MessageBox.Show("Are You Sure You Want Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (close == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void welcomeLBL_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm.ShowDialog();

        }

        private void loginAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
