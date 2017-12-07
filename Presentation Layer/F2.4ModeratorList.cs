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
    public partial class FModeratorList : Form
    {
        public FModeratorList()
        {
            InitializeComponent();
        }

        private void BBack2ManageEmployee5_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        private void FModeratorList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }
    }
}
