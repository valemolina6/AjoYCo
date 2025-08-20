namespace Molina.Valentina_TPI_PP1
{
    partial class frmModificarStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarStock));
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnEliminarStock = new System.Windows.Forms.Button();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.White;
            this.grpDatos.Controls.Add(this.btnEliminarStock);
            this.grpDatos.Controls.Add(this.cmbArticulos);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.txtUnidades);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.btnCargar);
            this.grpDatos.Location = new System.Drawing.Point(36, 38);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDatos.Size = new System.Drawing.Size(648, 325);
            this.grpDatos.TabIndex = 4;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Stock";
            // 
            // btnEliminarStock
            // 
            this.btnEliminarStock.BackColor = System.Drawing.Color.Red;
            this.btnEliminarStock.ForeColor = System.Drawing.Color.White;
            this.btnEliminarStock.Location = new System.Drawing.Point(9, 212);
            this.btnEliminarStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarStock.Name = "btnEliminarStock";
            this.btnEliminarStock.Size = new System.Drawing.Size(297, 43);
            this.btnEliminarStock.TabIndex = 23;
            this.btnEliminarStock.Text = "Eliminar Stock";
            this.btnEliminarStock.UseVisualStyleBackColor = false;
            this.btnEliminarStock.Click += new System.EventHandler(this.btnEliminarStock_Click);
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.BackColor = System.Drawing.Color.Red;
            this.cmbArticulos.ForeColor = System.Drawing.Color.White;
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(315, 85);
            this.cmbArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(254, 28);
            this.cmbArticulos.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre del articulo:";
            // 
            // txtUnidades
            // 
            this.txtUnidades.BackColor = System.Drawing.Color.Red;
            this.txtUnidades.ForeColor = System.Drawing.Color.White;
            this.txtUnidades.Location = new System.Drawing.Point(315, 121);
            this.txtUnidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(254, 26);
            this.txtUnidades.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad de unidades:";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Red;
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(315, 212);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(324, 43);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar stock";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmModificarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(735, 407);
            this.Controls.Add(this.grpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmModificarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar stock";
            this.Load += new System.EventHandler(this.frmModificarStock_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnEliminarStock;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCargar;
    }
}