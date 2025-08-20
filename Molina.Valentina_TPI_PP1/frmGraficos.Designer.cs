namespace Molina.Valentina_TPI_PP1
{
    partial class frmGraficos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficos));
            this.btnGraficar = new System.Windows.Forms.Button();
            this.chGraficar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chGraficar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGraficar
            // 
            this.btnGraficar.BackColor = System.Drawing.Color.White;
            this.btnGraficar.Location = new System.Drawing.Point(698, 712);
            this.btnGraficar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(300, 43);
            this.btnGraficar.TabIndex = 43;
            this.btnGraficar.Text = "Graficar";
            this.btnGraficar.UseVisualStyleBackColor = false;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // chGraficar
            // 
            chartArea1.Name = "ChartArea1";
            this.chGraficar.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chGraficar.Legends.Add(legend1);
            this.chGraficar.Location = new System.Drawing.Point(16, 18);
            this.chGraficar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chGraficar.Name = "chGraficar";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chGraficar.Series.Add(series1);
            this.chGraficar.Size = new System.Drawing.Size(981, 685);
            this.chGraficar.TabIndex = 42;
            this.chGraficar.Text = "chart1";
            this.chGraficar.Click += new System.EventHandler(this.chGraficar_Click);
            // 
            // frmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1018, 774);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.chGraficar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGraficos";
            ((System.ComponentModel.ISupportInitialize)(this.chGraficar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGraficar;
    }
}