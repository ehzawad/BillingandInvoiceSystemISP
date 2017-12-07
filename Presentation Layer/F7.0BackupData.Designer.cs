namespace Presentation_Layer
{
    partial class FBackupData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBackupData));
            this.BBackupData = new Bunifu.Framework.UI.BunifuTileButton();
            this.BSyncData = new Bunifu.Framework.UI.BunifuTileButton();
            this.BBackHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // BBackupData
            // 
            this.BBackupData.BackColor = System.Drawing.Color.SeaGreen;
            this.BBackupData.color = System.Drawing.Color.SeaGreen;
            this.BBackupData.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BBackupData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackupData.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackupData.ForeColor = System.Drawing.Color.Black;
            this.BBackupData.Image = ((System.Drawing.Image)(resources.GetObject("BBackupData.Image")));
            this.BBackupData.ImagePosition = 18;
            this.BBackupData.ImageZoom = 50;
            this.BBackupData.LabelPosition = 38;
            this.BBackupData.LabelText = "Back Up Data";
            this.BBackupData.Location = new System.Drawing.Point(14, 93);
            this.BBackupData.Margin = new System.Windows.Forms.Padding(6);
            this.BBackupData.Name = "BBackupData";
            this.BBackupData.Size = new System.Drawing.Size(200, 160);
            this.BBackupData.TabIndex = 0;
            // 
            // BSyncData
            // 
            this.BSyncData.BackColor = System.Drawing.Color.SeaGreen;
            this.BSyncData.color = System.Drawing.Color.SeaGreen;
            this.BSyncData.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.BSyncData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSyncData.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.BSyncData.ForeColor = System.Drawing.Color.Black;
            this.BSyncData.Image = ((System.Drawing.Image)(resources.GetObject("BSyncData.Image")));
            this.BSyncData.ImagePosition = 20;
            this.BSyncData.ImageZoom = 50;
            this.BSyncData.LabelPosition = 41;
            this.BSyncData.LabelText = "Sync Data";
            this.BSyncData.Location = new System.Drawing.Point(227, 93);
            this.BSyncData.Margin = new System.Windows.Forms.Padding(6);
            this.BSyncData.Name = "BSyncData";
            this.BSyncData.Size = new System.Drawing.Size(196, 160);
            this.BSyncData.TabIndex = 1;
            // 
            // BBackHome
            // 
            this.BBackHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BBackHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBackHome.BorderRadius = 0;
            this.BBackHome.ButtonText = "Back";
            this.BBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackHome.DisabledColor = System.Drawing.Color.Gray;
            this.BBackHome.Iconcolor = System.Drawing.Color.Transparent;
            this.BBackHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBackHome.Iconimage")));
            this.BBackHome.Iconimage_right = null;
            this.BBackHome.Iconimage_right_Selected = null;
            this.BBackHome.Iconimage_Selected = null;
            this.BBackHome.IconMarginLeft = 0;
            this.BBackHome.IconMarginRight = 0;
            this.BBackHome.IconRightVisible = true;
            this.BBackHome.IconRightZoom = 0D;
            this.BBackHome.IconVisible = true;
            this.BBackHome.IconZoom = 90D;
            this.BBackHome.IsTab = false;
            this.BBackHome.Location = new System.Drawing.Point(15, 12);
            this.BBackHome.Name = "BBackHome";
            this.BBackHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackHome.OnHovercolor = System.Drawing.Color.Teal;
            this.BBackHome.OnHoverTextColor = System.Drawing.Color.White;
            this.BBackHome.selected = false;
            this.BBackHome.Size = new System.Drawing.Size(100, 55);
            this.BBackHome.TabIndex = 10;
            this.BBackHome.Text = "Back";
            this.BBackHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackHome.Textcolor = System.Drawing.Color.White;
            this.BBackHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackHome.Click += new System.EventHandler(this.BBackHome_Click);
            // 
            // FBackupData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(437, 293);
            this.Controls.Add(this.BBackHome);
            this.Controls.Add(this.BSyncData);
            this.Controls.Add(this.BBackupData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FBackupData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup & Sync Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBackupData_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton BBackupData;
        private Bunifu.Framework.UI.BunifuTileButton BSyncData;
        private Bunifu.Framework.UI.BunifuFlatButton BBackHome;
    }
}