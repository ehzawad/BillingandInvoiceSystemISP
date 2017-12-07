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
    public partial class FExpenditure : Form
    {
        public FExpenditure()
        {
            InitializeComponent();
        }

        FFinance fFinance;
        public FExpenditure(FFinance fFinance)
        {
            InitializeComponent();
            this.fFinance = fFinance;
        }

        private void BBack2Finance_Click(object sender, EventArgs e)
        {
            FFinance fFinance = new FFinance();
            this.Hide();
            fFinance.Show();
        }

        private void FExpenditure_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
