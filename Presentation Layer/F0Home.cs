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
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();          
        }


        FLogin f1Login;

        public FHome(FLogin f1Login)
        {
            InitializeComponent();
            this.f1Login = f1Login;
            this.BackColor = Color.FromArgb(32,35,44);
        }

        private void F2Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Show Manage Customer Page on Button Click
        private void BManageCustomer_Click(object sender, EventArgs e)
        {
            FManageCustomer fManageCustomer = new FManageCustomer(this);
            this.Hide();
            fManageCustomer.Show();
        }

        private void BBackLogin_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            this.Hide();
            fLogin.Show();
        }

        private void BManageEmployee_Click(object sender, EventArgs e)
        {
            FManageEmployee fManageEmployee = new FManageEmployee();
            this.Hide();
            fManageEmployee.Show();
        }

        private void BPackageInformation_Click(object sender, EventArgs e)
        {
            FPackageInfo fPackageInfo = new FPackageInfo();
            this.Hide();
            fPackageInfo.Show();
        }

        private void BBackupData_Click(object sender, EventArgs e)
        {
            FBackupData fBackupData = new FBackupData();
            this.Hide();
            fBackupData.Show();
        }

        private void BManagePayment_Click(object sender, EventArgs e)
        {
            FManagePayment fManagePayment = new FManagePayment(this);
            this.Hide();
            fManagePayment.Show();
        }

        private void BFinance_Click(object sender, EventArgs e)
        {
            FFinance fFinance = new FFinance(this);
            this.Hide();
            fFinance.Show();
        }

        private void BReports_Click(object sender, EventArgs e)
        {
            FReports fReports = new FReports(this);
            this.Hide();
            fReports.Show();
        }

        private void BAdminInfo_Click(object sender, EventArgs e)
        {
            FAdmin fAdmin = new FAdmin(this);
            this.Hide();
            fAdmin.Show();
        }
    }
}
