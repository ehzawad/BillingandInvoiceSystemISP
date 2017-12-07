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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(32, 35, 44);
        }


        private void BLogin_Click(object sender, EventArgs e)
        {
            FHome f2home = new FHome(this);
            this.Hide();
            f2home.Show();
        }

        private void F1Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Check The textbox is edited or not and set textbox blank when get focused
        bool TUsernameEdited;
        private void TUsername_Enter(object sender, EventArgs e)
        {
            if (!TUsernameEdited)
            {
                TUsername.Text = "";
            }
        }

        private void TUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            TUsernameEdited = !char.IsControl(e.KeyChar);
        }

        bool TPasswordEdited;
        private void TPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            TPasswordEdited = !char.IsControl(e.KeyChar);
        }

        private void TPassword_Enter(object sender, EventArgs e)
        {
            if (!TPasswordEdited)
            {
                TPassword.Text = "";
            }
        }

        #endregion

        private void BForgotPassword_Click(object sender, EventArgs e)
        {
            FForgotPassword fForgotPassword = new FForgotPassword();
            this.Hide();
            fForgotPassword.Show();
        }
    }
}
