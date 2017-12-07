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
    public partial class FEmployeeList : Form
    {
        public FEmployeeList()
        {
            InitializeComponent();
        }

        FManageEmployee fManageEmployee;
        public FEmployeeList(FManageEmployee fManageEmployee)
        {
            InitializeComponent();
            this.fManageEmployee = fManageEmployee;
        }

        private void BBack2ManageCustomer3_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        private void F2_FormClosing(object sender, FormClosingEventArgs e)
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
