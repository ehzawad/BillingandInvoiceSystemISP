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
    public partial class FAreawiseCollection : Form
    {
        public FAreawiseCollection()
        {
            InitializeComponent();
        }

        FReports fReports;
        public FAreawiseCollection(FReports fReports)
        {
            InitializeComponent();
            this.fReports = fReports;
        }

        private void FAreawiseCollection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBackReports2_Click(object sender, EventArgs e)
        {
            FReports fReports = new FReports();
            this.Hide();
            fReports.Show();
        }
    }
}
