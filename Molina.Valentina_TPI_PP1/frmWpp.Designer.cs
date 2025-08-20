namespace Molina.Valentina_TPI_PP1
{
    partial class frmWpp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWpp));
            this.wvWpp = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wvWpp)).BeginInit();
            this.SuspendLayout();
            // 
            // wvWpp
            // 
            this.wvWpp.AllowExternalDrop = true;
            this.wvWpp.CreationProperties = null;
            this.wvWpp.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvWpp.Location = new System.Drawing.Point(12, 12);
            this.wvWpp.Name = "wvWpp";
            this.wvWpp.Size = new System.Drawing.Size(1264, 725);
            this.wvWpp.TabIndex = 0;
            this.wvWpp.ZoomFactor = 1D;
            // 
            // frmWpp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1288, 749);
            this.Controls.Add(this.wvWpp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWpp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmWpp";
            this.Load += new System.EventHandler(this.frmWpp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvWpp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvWpp;
    }
}