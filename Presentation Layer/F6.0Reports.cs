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
    public partial class FReports : Form
    {
        public FReports()
        {
            InitializeComponent();
        }

        FHome fHome;
        public FReports(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;
        }

        private void FReports_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2HomeFromreports_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void BProfitPerMonth_Click(object sender, EventArgs e)
        {
            FProfitPerMonth fProfitPerMonth = new FProfitPerMonth(this);
            this.Hide();
            fProfitPerMonth.Show();
        }

        private void BMonthlyCollection_Click(object sender, EventArgs e)
        {
            FMonthlyCollection fMonthlyCollection = new FMonthlyCollection(this);
            this.Hide();
            fMonthlyCollection.Show();
        }

        private void BMonthlyExpense_Click(object sender, EventArgs e)
        {
            FMonthlyExpense fMonthlyExpense = new FMonthlyExpense(this);
            this.Hide();
            fMonthlyExpense.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            FAreawiseCollection fAreawiseCollection = new FAreawiseCollection(this);
            this.Hide();
            fAreawiseCollection.Show();
        }

        private void BAreawiseConnection_Click(object sender, EventArgs e)
        {
            FAreawiseConnection fAreawiseConnection = new FAreawiseConnection(this);
            this.Hide();
            fAreawiseConnection.Show();
        }
    }
}
