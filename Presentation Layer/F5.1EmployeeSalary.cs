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
    public partial class FEmployeeSalary : Form
    {
        public FEmployeeSalary()
        {
            InitializeComponent();
        }

        FFinance fFinance;
        public FEmployeeSalary(FFinance fFinance)
        {
            InitializeComponent();
            this.fFinance = fFinance;
        }

        private void FEmployeeSalary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageEmployee_Click(object sender, EventArgs e)
        {
            FFinance fFinance = new FFinance();
            this.Hide();
            fFinance.Show();
        }
    }
}
