namespace Presentation_Layer
{
    partial class FProfitPerMonth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProfitPerMonth));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BBack2Report5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // BBack2Report5
            // 
            this.BBack2Report5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(26)))), ((int)(((byte)(32)))));
            this.BBack2Report5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Report5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBack2Report5.BorderRadius = 0;
            this.BBack2Report5.ButtonText = "Back";
            this.BBack2Report5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBack2Report5.DisabledColor = System.Drawing.Color.Gray;
            this.BBack2Report5.Iconcolor = System.Drawing.Color.Transparent;
            this.BBack2Report5.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBack2Report5.Iconimage")));
            this.BBack2Report5.Iconimage_right = null;
            this.BBack2Report5.Iconimage_right_Selected = null;
            this.BBack2Report5.Iconimage_Selected = null;
            this.BBack2Report5.IconMarginLeft = 0;
            this.BBack2Report5.IconMarginRight = 0;
            this.BBack2Report5.IconRightVisible = true;
            this.BBack2Report5.IconRightZoom = 0D;
            this.BBack2Report5.IconVisible = true;
            this.BBack2Report5.IconZoom = 90D;
            this.BBack2Report5.IsTab = false;
            this.BBack2Report5.Location = new System.Drawing.Point(12, 12);
            this.BBack2Report5.Name = "BBack2Report5";
            this.BBack2Report5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBack2Report5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(56)))));
            this.BBack2Report5.OnHoverTextColor = System.Drawing.Color.White;
            this.BBack2Report5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 20);
            this.BBack2Report5.selected = false;
            this.BBack2Report5.Size = new System.Drawing.Size(101, 47);
            this.BBack2Report5.TabIndex = 7;
            this.BBack2Report5.Text = "Back";
            this.BBack2Report5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBack2Report5.Textcolor = System.Drawing.Color.White;
            this.BBack2Report5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack2Report5.Click += new System.EventHandler(this.BBack2Report5_Click);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(12, 99);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(145, 35);
            this.bunifuDropdown1.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(195, 34);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(538, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // FProfitPerMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(756, 346);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.BBack2Report5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FProfitPerMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profit Per Month";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FProfitPerMonth_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton BBack2Report5;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}