using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class FNewEntry : Form
    {
        public FNewEntry()
        {
            InitializeComponent();
        }

        FManageCustomer FManageCustomer;
        public FNewEntry(FManageCustomer fManageCustomer)
        {
            InitializeComponent();
            this.FManageCustomer = fManageCustomer;
            this.BackColor = Color.FromArgb(32, 35, 44);
        }

        private void FNewEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageCustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManageCustomer fManageCustomer = new FManageCustomer();
            fManageCustomer.Show();
            this.Hide();
        }
    }
}
