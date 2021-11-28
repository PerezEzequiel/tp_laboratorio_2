
namespace WinFormApp
{
    partial class FrmEstadistica
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbEstadistica = new System.Windows.Forms.ComboBox();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitulo.Location = new System.Drawing.Point(136, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 54);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estadisticas";
            // 
            // cmbEstadistica
            // 
            this.cmbEstadistica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadistica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEstadistica.FormattingEnabled = true;
            this.cmbEstadistica.Items.AddRange(new object[] {
            "Total instrumentos cuerda",
            "Total instrumentos viento",
            "Total instrumentos percusion",
            "Total instrumentos origen Estados Unidos",
            "Total instrumentos origen Mexico",
            "Total instrumentos origen Peru",
            "Total instrumentos origen Chino",
            "Empleados por pagar"});
            this.cmbEstadistica.Location = new System.Drawing.Point(14, 128);
            this.cmbEstadistica.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEstadistica.Name = "cmbEstadistica";
            this.cmbEstadistica.Size = new System.Drawing.Size(453, 36);
            this.cmbEstadistica.TabIndex = 1;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.lblSeleccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccion.Location = new System.Drawing.Point(14, 96);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(102, 28);
            this.lblSeleccion.TabIndex = 2;
            this.lblSeleccion.Text = "Seleccione";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(316, 196);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(151, 47);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(479, 256);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.cmbEstadistica);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.Load += new System.EventHandler(this.FrmEstadistica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbEstadistica;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnAceptar;
    }
}