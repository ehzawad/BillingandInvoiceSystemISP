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
    public partial class FFinance : Form
    {
        public FFinance()
        {
            InitializeComponent();
        }

        FHome fHome;
        public FFinance(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;
        }

        private void BEmployeeSalary_Click(object sender, EventArgs e)
        {
            FEmployeeSalary fEmployeeSalary = new FEmployeeSalary(this);
            this.Hide();
            fEmployeeSalary.Show();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void FFinance_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BExpenditure_Click(object sender, EventArgs e)
        {
            FExpenditure fExpenditure = new FExpenditure(this);
            this.Hide();
            fExpenditure.Show();
        }

        private void BTotalCost_Click(object sender, EventArgs e)
        {
            FTotalCost fTotalCost = new FTotalCost(this);
            this.Hide();
            fTotalCost.Show();
        }
    }
}
