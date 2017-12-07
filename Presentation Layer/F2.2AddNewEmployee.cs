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
    public partial class FAddNewEmployee : Form
    {
        public FAddNewEmployee()
        {
            InitializeComponent();
        }

        FManageEmployee fManageEmployee;
        public FAddNewEmployee(FManageEmployee fManageEmployee)
        {
            InitializeComponent();
            this.fManageEmployee = fManageEmployee;
        }

        private void FAddNewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBack2ManageEmployee_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }
    }
}
