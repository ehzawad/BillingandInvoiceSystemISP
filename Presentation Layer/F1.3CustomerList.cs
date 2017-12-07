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
    public partial class FCustomerList : Form
    {
        public FCustomerList()
        {
            InitializeComponent();
        }


        FManageCustomer fManageCustomer;

        public FCustomerList(FManageCustomer fManageCustomer)
        {
            InitializeComponent();
            this.fManageCustomer = fManageCustomer;
            this.BackColor = Color.FromArgb(32, 35, 44);
        }

        private void FCustomerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageCustomer2_Click(object sender, EventArgs e)
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
