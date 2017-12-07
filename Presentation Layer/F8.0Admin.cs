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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        FHome fHome;
        public FAdmin(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;
        }

        private void BBackLoginA_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void FAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
