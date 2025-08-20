namespace Molina.Valentina_TPI_PP1
{
    partial class frmCargarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarVenta));
            this.grpVenta = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbArticulos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoVenta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.grpVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVenta
            // 
            this.grpVenta.BackColor = System.Drawing.Color.White;
            this.grpVenta.Controls.Add(this.txtMonto);
            this.grpVenta.Controls.Add(this.cmbArticulos);
            this.grpVenta.Controls.Add(this.label3);
            this.grpVenta.Controls.Add(this.txtUnidades);
            this.grpVenta.Controls.Add(this.label6);
            this.grpVenta.Controls.Add(this.label1);
            this.grpVenta.Controls.Add(this.Calendario);
            this.grpVenta.Controls.Add(this.label4);
            this.grpVenta.Controls.Add(this.cmbTipoVenta);
            this.grpVenta.Controls.Add(this.label2);
            this.grpVenta.Controls.Add(this.btnCargar);
            this.grpVenta.Location = new System.Drawing.Point(24, 28);
            this.grpVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVenta.Name = "grpVenta";
            this.grpVenta.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVenta.Size = new System.Drawing.Size(720, 697);
            this.grpVenta.TabIndex = 4;
            this.grpVenta.TabStop = false;
            this.grpVenta.Text = "Carga de Venta";
            this.grpVenta.Enter += new System.EventHandler(this.grpVenta_Enter);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.Red;
            this.txtMonto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMonto.Location = new System.Drawing.Point(278, 477);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(338, 26);
            this.txtMonto.TabIndex = 29;
            // 
            // cmbArticulos
            // 
            this.cmbArticulos.BackColor = System.Drawing.Color.Red;
            this.cmbArticulos.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbArticulos.FormattingEnabled = true;
            this.cmbArticulos.Location = new System.Drawing.Point(278, 395);
            this.cmbArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbArticulos.Name = "cmbArticulos";
            this.cmbArticulos.Size = new System.Drawing.Size(338, 28);
            this.cmbArticulos.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nombre del articulo:";
            // 
            // txtUnidades
            // 
            this.txtUnidades.BackColor = System.Drawing.Color.Red;
            this.txtUnidades.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUnidades.Location = new System.Drawing.Point(278, 437);
            this.txtUnidades.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(338, 26);
            this.txtUnidades.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 448);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cantidad de unidades:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha:";
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(278, 86);
            this.Calendario.Margin = new System.Windows.Forms.Padding(14);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 5;
            this.Calendario.TitleBackColor = System.Drawing.Color.Red;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 488);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Monto de venta:";
            // 
            // cmbTipoVenta
            // 
            this.cmbTipoVenta.BackColor = System.Drawing.Color.Red;
            this.cmbTipoVenta.ForeColor = System.Drawing.SystemColors.Window;
            this.cmbTipoVenta.FormattingEnabled = true;
            this.cmbTipoVenta.Location = new System.Drawing.Point(278, 354);
            this.cmbTipoVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTipoVenta.Name = "cmbTipoVenta";
            this.cmbTipoVenta.Size = new System.Drawing.Size(338, 28);
            this.cmbTipoVenta.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Medio de pago:";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Red;
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(108, 589);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(510, 45);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // frmCargarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(769, 758);
            this.Controls.Add(this.grpVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCargarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar una venta";
            this.Load += new System.EventHandler(this.frmCargarVenta_Load);
            this.grpVenta.ResumeLayout(false);
            this.grpVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVenta;
        private System.Windows.Forms.ComboBox cmbTipoVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbArticulos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto;
    }
}