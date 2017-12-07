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
    public partial class FBackupData : Form
    {
        public FBackupData()
        {
            InitializeComponent();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FHome fHome = new FHome();
            this.Hide();
            fHome.Show();
        }

        private void FBackupData_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
