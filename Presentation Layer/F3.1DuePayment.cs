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
    public partial class FDuePayment : Form
    {
        public FDuePayment()
        {
            InitializeComponent();
        }

        FManagePayment fManagePayment;
        public FDuePayment(FManagePayment fManagePayment)
        {
            InitializeComponent();
            this.fManagePayment = fManagePayment;
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManagePayment fManagePayment = new FManagePayment();
            this.Hide();
            fManagePayment.Show();
        }

        private void FDuePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
