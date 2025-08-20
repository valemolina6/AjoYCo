namespace Molina.Valentina_TPI_PP1
{
    partial class frmUbicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUbicacion));
            this.wvUbicacion = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wvUbicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // wvUbicacion
            // 
            this.wvUbicacion.AllowExternalDrop = true;
            this.wvUbicacion.CreationProperties = null;
            this.wvUbicacion.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvUbicacion.Location = new System.Drawing.Point(12, 12);
            this.wvUbicacion.Name = "wvUbicacion";
            this.wvUbicacion.Size = new System.Drawing.Size(1262, 722);
            this.wvUbicacion.TabIndex = 0;
            this.wvUbicacion.ZoomFactor = 1D;
            // 
            // frmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1286, 746);
            this.Controls.Add(this.wvUbicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUbicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUbicacion";
            this.Load += new System.EventHandler(this.frmUbicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvUbicacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wvUbicacion;
    }
}