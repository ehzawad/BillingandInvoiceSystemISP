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
    public partial class FAreawiseConnection : Form
    {
        public FAreawiseConnection()
        {
            InitializeComponent();
        }

        FReports fReports;
        public FAreawiseConnection(FReports fReports)
        {
            InitializeComponent();
            this.fReports = fReports;
        }

        private void FAreawiseConnection_FormClosing(object sender, FormClosingEventArgs e)
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
