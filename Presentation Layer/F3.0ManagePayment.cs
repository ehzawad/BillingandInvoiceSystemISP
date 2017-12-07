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
    public partial class FManagePayment : Form
    {
        public FManagePayment()
        {
            InitializeComponent();
        }

        FHome fHome;
        public FManagePayment(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;
        }

        private void BDuePaymentList_Click(object sender, EventArgs e)
        {
            FDuePayment fDuePayment = new FDuePayment();
            this.Hide();
            fDuePayment.Show();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FHome fHome2 = new FHome();
            this.Hide();
            fHome2.Show();
        }

        private void FManagePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BAllPaymentList_Click(object sender, EventArgs e)
        {
            FAllPaymentList fAllPaymentList = new FAllPaymentList(this);
            this.Hide();
            fAllPaymentList.Show();
        }
    }
}
