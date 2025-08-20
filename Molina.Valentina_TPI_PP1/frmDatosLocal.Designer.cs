namespace Molina.Valentina_TPI_PP1
{
    partial class frmDatosLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosLocal));
            this.btnUbicacion = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUbicacion
            // 
            this.btnUbicacion.Location = new System.Drawing.Point(74, 56);
            this.btnUbicacion.Name = "btnUbicacion";
            this.btnUbicacion.Size = new System.Drawing.Size(237, 49);
            this.btnUbicacion.TabIndex = 0;
            this.btnUbicacion.Text = "Ubicacion";
            this.btnUbicacion.UseVisualStyleBackColor = true;
            this.btnUbicacion.Click += new System.EventHandler(this.btnUbicacion_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.Location = new System.Drawing.Point(74, 111);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(237, 50);
            this.btnInstagram.TabIndex = 1;
            this.btnInstagram.Text = "Instragram";
            this.btnInstagram.UseVisualStyleBackColor = true;
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
            // 
            // frmDatosLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(385, 222);
            this.Controls.Add(this.btnInstagram);
            this.Controls.Add(this.btnUbicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Local";
            this.Load += new System.EventHandler(this.frmDatosLocal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUbicacion;
        private System.Windows.Forms.Button btnInstagram;
    }
}