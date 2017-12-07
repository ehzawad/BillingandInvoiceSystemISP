namespace Presentation_Layer
{
    partial class FLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BForgotPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(104, 110);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(136, 37);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Username";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(104, 162);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(137, 40);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // TUsername
            // 
            this.TUsername.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TUsername.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TUsername.BorderThickness = 3;
            this.TUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TUsername.ForeColor = System.Drawing.Color.White;
            this.TUsername.isPassword = false;
            this.TUsername.Location = new System.Drawing.Point(251, 108);
            this.TUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TUsername.Name = "TUsername";
            this.TUsername.Size = new System.Drawing.Size(196, 35);
            this.TUsername.TabIndex = 3;
            this.TUsername.Text = "username";
            this.TUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TUsername.Enter += new System.EventHandler(this.TUsername_Enter);
            this.TUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TUsername_KeyPress);
            // 
            // TPassword
            // 
            this.TPassword.BorderColorFocused = System.Drawing.Color.DarkCyan;
            this.TPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TPassword.BorderColorMouseHover = System.Drawing.Color.DarkCyan;
            this.TPassword.BorderThickness = 3;
            this.TPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TPassword.ForeColor = System.Drawing.Color.White;
            this.TPassword.isPassword = true;
            this.TPassword.Location = new System.Drawing.Point(251, 157);
            this.TPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TPassword.Name = "TPassword";
            this.TPassword.Size = new System.Drawing.Size(197, 35);
            this.TPassword.TabIndex = 4;
            this.TPassword.Text = "password";
            this.TPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TPassword.Enter += new System.EventHandler(this.TPassword_Enter);
            this.TPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPassword_KeyPress);
            // 
            // BForgotPassword
            // 
            this.BForgotPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BForgotPassword.BackColor = System.Drawing.Color.Teal;
            this.BForgotPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BForgotPassword.BorderRadius = 0;
            this.BForgotPassword.ButtonText = "FORGOT PASSWORD";
            this.BForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BForgotPassword.DisabledColor = System.Drawing.Color.Gray;
            this.BForgotPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.BForgotPassword.Iconimage = ((System.Drawing.Image)(resources.GetObject("BForgotPassword.Iconimage")));
            this.BForgotPassword.Iconimage_right = null;
            this.BForgotPassword.Iconimage_right_Selected = null;
            this.BForgotPassword.Iconimage_Selected = null;
            this.BForgotPassword.IconMarginLeft = 0;
            this.BForgotPassword.IconMarginRight = 0;
            this.BForgotPassword.IconRightVisible = true;
            this.BForgotPassword.IconRightZoom = 0D;
            this.BForgotPassword.IconVisible = true;
            this.BForgotPassword.IconZoom = 90D;
            this.BForgotPassword.IsTab = false;
            this.BForgotPassword.Location = new System.Drawing.Point(254, 274);
            this.BForgotPassword.Name = "BForgotPassword";
            this.BForgotPassword.Normalcolor = System.Drawing.Color.Teal;
            this.BForgotPassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BForgotPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.BForgotPassword.selected = false;
            this.BForgotPassword.Size = new System.Drawing.Size(193, 37);
            this.BForgotPassword.TabIndex = 6;
            this.BForgotPassword.Text = "FORGOT PASSWORD";
            this.BForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BForgotPassword.Textcolor = System.Drawing.Color.White;
            this.BForgotPassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BForgotPassword.Click += new System.EventHandler(this.BForgotPassword_Click);
            // 
            // BLogin
            // 
            this.BLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BLogin.BackColor = System.Drawing.Color.Teal;
            this.BLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BLogin.BorderRadius = 0;
            this.BLogin.ButtonText = "LOG IN";
            this.BLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BLogin.DisabledColor = System.Drawing.Color.Gray;
            this.BLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.BLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("BLogin.Iconimage")));
            this.BLogin.Iconimage_right = null;
            this.BLogin.Iconimage_right_Selected = null;
            this.BLogin.Iconimage_Selected = null;
            this.BLogin.IconMarginLeft = 0;
            this.BLogin.IconMarginRight = 0;
            this.BLogin.IconRightVisible = true;
            this.BLogin.IconRightZoom = 0D;
            this.BLogin.IconVisible = true;
            this.BLogin.IconZoom = 90D;
            this.BLogin.IsTab = false;
            this.BLogin.Location = new System.Drawing.Point(254, 216);
            this.BLogin.Name = "BLogin";
            this.BLogin.Normalcolor = System.Drawing.Color.Teal;
            this.BLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.BLogin.selected = false;
            this.BLogin.Size = new System.Drawing.Size(193, 37);
            this.BLogin.TabIndex = 5;
            this.BLogin.Text = "LOG IN";
            this.BLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BLogin.Textcolor = System.Drawing.Color.White;
            this.BLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(89, 32);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(407, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "ISP Management System";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(585, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BForgotPassword);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.TUsername);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG IN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F1Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox TUsername;
        private Bunifu.Framework.UI.BunifuMetroTextbox TPassword;
        private Bunifu.Framework.UI.BunifuFlatButton BForgotPassword;
        private Bunifu.Framework.UI.BunifuFlatButton BLogin;
        private System.Windows.Forms.Label label1;
    }
}

