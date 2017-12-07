namespace Presentation_Layer
{
    partial class FAreawiseConnection
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAreawiseConnection));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BBackReports2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(239, 90);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(455, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // BBackReports2
            // 
            this.BBackReports2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BBackReports2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackReports2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BBackReports2.BorderRadius = 0;
            this.BBackReports2.ButtonText = "Back";
            this.BBackReports2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBackReports2.DisabledColor = System.Drawing.Color.Gray;
            this.BBackReports2.Iconcolor = System.Drawing.Color.Transparent;
            this.BBackReports2.Iconimage = ((System.Drawing.Image)(resources.GetObject("BBackReports2.Iconimage")));
            this.BBackReports2.Iconimage_right = null;
            this.BBackReports2.Iconimage_right_Selected = null;
            this.BBackReports2.Iconimage_Selected = null;
            this.BBackReports2.IconMarginLeft = 0;
            this.BBackReports2.IconMarginRight = 0;
            this.BBackReports2.IconRightVisible = true;
            this.BBackReports2.IconRightZoom = 0D;
            this.BBackReports2.IconVisible = true;
            this.BBackReports2.IconZoom = 90D;
            this.BBackReports2.IsTab = false;
            this.BBackReports2.Location = new System.Drawing.Point(12, 12);
            this.BBackReports2.Name = "BBackReports2";
            this.BBackReports2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.BBackReports2.OnHovercolor = System.Drawing.Color.Teal;
            this.BBackReports2.OnHoverTextColor = System.Drawing.Color.White;
            this.BBackReports2.selected = false;
            this.BBackReports2.Size = new System.Drawing.Size(100, 55);
            this.BBackReports2.TabIndex = 14;
            this.BBackReports2.Text = "Back";
            this.BBackReports2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackReports2.Textcolor = System.Drawing.Color.White;
            this.BBackReports2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBackReports2.Click += new System.EventHandler(this.BBackReports2_Click);
            // 
            // FAreawiseConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(722, 415);
            this.Controls.Add(this.BBackReports2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FAreawiseConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Areawise Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAreawiseConnection_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuFlatButton BBackReports2;
    }
}