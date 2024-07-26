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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutForm_Activated(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ActiveCaption;

        }

        private void AboutForm_Deactivate(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;

        }
    }
}
