namespace Molina.Valentina_TPI_PP1
{
    partial class frmInstagram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstagram));
            this.wvInstagram = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wvInstagram)).BeginInit();
            this.SuspendLayout();
            // 
            // wvInstagram
            // 
            this.wvInstagram.AllowExternalDrop = true;
            this.wvInstagram.CreationProperties = null;
            this.wvInstagram.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvInstagram.Location = new System.Drawing.Point(12, 12);
            this.wvInstagram.Name = "wvInstagram";
            this.wvInstagram.Size = new System.Drawing.Size(1264, 720);
            this.wvInstagram.TabIndex = 0;
            this.wvInstagram.ZoomFactor = 1D;
            this.wvInstagram.Click += new System.EventHandler(this.wvInstagram_Click);
            // 
            // frmInstagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1288, 744);
            this.Controls.Add(this.wvInstagram);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInstagram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInstagram";
            this.Load += new System.EventHandler(this.frmInstagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvInstagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvInstagram;
    }
}