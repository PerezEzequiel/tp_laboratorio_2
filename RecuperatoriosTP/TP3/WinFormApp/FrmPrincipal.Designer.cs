
namespace WinFormApp
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnAgregarEmpleados = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.txtGanancias = new System.Windows.Forms.TextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.rchTxtInformacion = new System.Windows.Forms.RichTextBox();
            this.lblInfoMuestra = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnAgregarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarStock.Location = new System.Drawing.Point(25, 217);
            this.btnAgregarStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(218, 48);
            this.btnAgregarStock.TabIndex = 1;
            this.btnAgregarStock.Text = "Agregar Stock";
            this.btnAgregarStock.UseVisualStyleBackColor = false;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVenta.Location = new System.Drawing.Point(25, 329);
            this.btnVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(218, 47);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Agregar Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnAgregarEmpleados
            // 
            this.btnAgregarEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnAgregarEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarEmpleados.Location = new System.Drawing.Point(25, 273);
            this.btnAgregarEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarEmpleados.Name = "btnAgregarEmpleados";
            this.btnAgregarEmpleados.Size = new System.Drawing.Size(218, 48);
            this.btnAgregarEmpleados.TabIndex = 3;
            this.btnAgregarEmpleados.Text = "Agregar Empleados";
            this.btnAgregarEmpleados.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleados.Click += new System.EventHandler(this.btnAgregarEmpleados_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.lblNombre.Location = new System.Drawing.Point(25, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(174, 37);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Informacion";
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInformacion.Font = new System.Drawing.Font("Segoe UI Light", 10.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblInformacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.lblInformacion.Location = new System.Drawing.Point(25, 79);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(54, 25);
            this.lblInformacion.TabIndex = 6;
            this.lblInformacion.Text = "label2";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstadisticas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstadisticas.Location = new System.Drawing.Point(761, 0);
            this.btnEstadisticas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(157, 69);
            this.btnEstadisticas.TabIndex = 8;
            this.btnEstadisticas.Text = "Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStock.Location = new System.Drawing.Point(0, 0);
            this.btnStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(138, 69);
            this.btnStock.TabIndex = 10;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnEstadisticas);
            this.panel1.Location = new System.Drawing.Point(293, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 69);
            this.panel1.TabIndex = 11;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmpleados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmpleados.Location = new System.Drawing.Point(499, 1);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(165, 69);
            this.btnEmpleados.TabIndex = 12;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVentas.Location = new System.Drawing.Point(245, -2);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(138, 69);
            this.btnVentas.TabIndex = 11;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.lblGanancias.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGanancias.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGanancias.Location = new System.Drawing.Point(25, 472);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(146, 37);
            this.lblGanancias.TabIndex = 12;
            this.lblGanancias.Text = "Ganancias";
            // 
            // txtGanancias
            // 
            this.txtGanancias.BackColor = System.Drawing.Color.LimeGreen;
            this.txtGanancias.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGanancias.Location = new System.Drawing.Point(25, 524);
            this.txtGanancias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGanancias.Name = "txtGanancias";
            this.txtGanancias.ReadOnly = true;
            this.txtGanancias.Size = new System.Drawing.Size(198, 34);
            this.txtGanancias.TabIndex = 13;
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.lblCapital.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapital.Location = new System.Drawing.Point(25, 567);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(108, 37);
            this.lblCapital.TabIndex = 14;
            this.lblCapital.Text = "Capital";
            // 
            // txtCapital
            // 
            this.txtCapital.BackColor = System.Drawing.Color.Red;
            this.txtCapital.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCapital.Location = new System.Drawing.Point(25, 611);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.ReadOnly = true;
            this.txtCapital.Size = new System.Drawing.Size(198, 34);
            this.txtCapital.TabIndex = 15;
            // 
            // rchTxtInformacion
            // 
            this.rchTxtInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(237)))));
            this.rchTxtInformacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchTxtInformacion.Location = new System.Drawing.Point(293, 137);
            this.rchTxtInformacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rchTxtInformacion.Name = "rchTxtInformacion";
            this.rchTxtInformacion.ReadOnly = true;
            this.rchTxtInformacion.Size = new System.Drawing.Size(918, 549);
            this.rchTxtInformacion.TabIndex = 16;
            this.rchTxtInformacion.Text = "";
            // 
            // lblInfoMuestra
            // 
            this.lblInfoMuestra.AutoSize = true;
            this.lblInfoMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(120)))), ((int)(((byte)(68)))));
            this.lblInfoMuestra.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoMuestra.Location = new System.Drawing.Point(690, 83);
            this.lblInfoMuestra.Name = "lblInfoMuestra";
            this.lblInfoMuestra.Size = new System.Drawing.Size(190, 41);
            this.lblInfoMuestra.TabIndex = 17;
            this.lblInfoMuestra.Text = "Informacion";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.btnExportar.Location = new System.Drawing.Point(289, 696);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(142, 51);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(71)))), ((int)(((byte)(58)))));
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImportar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(193)))), ((int)(((byte)(66)))));
            this.btnImportar.Location = new System.Drawing.Point(438, 696);
            this.btnImportar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(154, 51);
            this.btnImportar.TabIndex = 19;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1225, 763);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblInfoMuestra);
            this.Controls.Add(this.rchTxtInformacion);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.lblCapital);
            this.Controls.Add(this.txtGanancias);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregarEmpleados);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnAgregarStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Activated += new System.EventHandler(this.FrmPrincipal_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmPrincipal_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnAgregarEmpleados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.TextBox txtGanancias;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.RichTextBox rchTxtInformacion;
        private System.Windows.Forms.Label lblInfoMuestra;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
    }
}