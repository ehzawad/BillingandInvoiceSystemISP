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
    public partial class FManageCustomer : Form
    {
        public FManageCustomer()
        {
            InitializeComponent();
        }

        FHome fHome;

        public FManageCustomer(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;
            this.BackColor = Color.FromArgb(32, 35, 44);
        }

        private void FManageCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BNewEntry_Click(object sender, EventArgs e)
        {
            FNewEntry fNewEntry = new FNewEntry(this);
            this.Hide();
            fNewEntry.Show();
        }

        private void BCustomerList_Click(object sender, EventArgs e)
        {
            FCustomerList fCustomerList = new FCustomerList(this);
            this.Hide();
            fCustomerList.Show();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }
    }
}
