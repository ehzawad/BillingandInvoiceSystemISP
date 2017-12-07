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
    public partial class FManageEmployee : Form
    {
        public FManageEmployee()
        {
            InitializeComponent();
        }

        FHome fHome2;
        public FManageEmployee(FHome fHome2)
        {
            InitializeComponent();
            this.fHome2 = fHome2;
            this.BackColor = Color.FromArgb(32, 35, 44);
        }

        // Form Closing
        private void FManageEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BBackHome_Click(object sender, EventArgs e)
        {
            FHome fHome2 = new FHome();
            this.Hide();
            fHome2.Show();
        }

        private void BNewEntry_Click(object sender, EventArgs e)
        {
            FAddNewEmployee fAddNewEmployee = new FAddNewEmployee(this);
            this.Hide();
            fAddNewEmployee.Show();
        }

        private void BEmployeeList_Click(object sender, EventArgs e)
        {
            FEmployeeList fEmployeeList = new FEmployeeList();
            this.Hide();
            fEmployeeList.Show();
        }

        private void BModeratorList_Click(object sender, EventArgs e)
        {
            FModeratorList fModeratorList = new FModeratorList();
            this.Hide();
            fModeratorList.Show();
        }
    }
}
