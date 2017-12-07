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
    public partial class FPackageInfo : Form
    {
        public FPackageInfo()
        {
            InitializeComponent();
        }

        FHome fHome;
        public FPackageInfo(FHome fHome)
        {
            InitializeComponent();
            this.fHome = fHome;
        }

        private void FPackageInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBackHome3_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void BAddNewPackage_Click(object sender, EventArgs e)
        {
            FAddNewPackage fAddNewPackage = new FAddNewPackage();
            this.Hide();
            fAddNewPackage.Show();
        }
    }
}
