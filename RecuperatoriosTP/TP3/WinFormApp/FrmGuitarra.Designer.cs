﻿
namespace WinFormApp
{
    partial class FrmGuitarra
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
            this.txtCantCuerdas = new System.Windows.Forms.TextBox();
            this.lblCantidadCuerdas = new System.Windows.Forms.Label();
            this.lblTipoGuitarra = new System.Windows.Forms.Label();
            this.cmbBoxTipoGuitarra = new System.Windows.Forms.ComboBox();
            this.grpBoxEsUsado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // txtModelo
            // 
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // cmbBoxOrigen
            // 
            this.cmbBoxOrigen.Items.AddRange(new object[] {
            EOrigen.EstadosUnidos,
            EOrigen.Mexico,
            EOrigen.Peru,
            EOrigen.Chino,
            EOrigen.EstadosUnidos,
            EOrigen.Mexico,
            EOrigen.Peru,
            EOrigen.Chino});
            this.cmbBoxOrigen.Size = new System.Drawing.Size(420, 39);
            // 
            // grpBoxEsUsado
            // 
            this.grpBoxEsUsado.Location = new System.Drawing.Point(14, 344);
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.TabStop = false;
            // 
            // radioBtnSi
            // 
            this.radioBtnSi.Checked = true;
            // 
            // txtCosto
            // 
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCosto.TabIndex = 10;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPorcentaje.TabIndex = 11;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(356, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 59);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Guitarra";
            // 
            // txtCantCuerdas
            // 
            this.txtCantCuerdas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantCuerdas.Location = new System.Drawing.Point(21, 516);
            this.txtCantCuerdas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantCuerdas.Name = "txtCantCuerdas";
            this.txtCantCuerdas.Size = new System.Drawing.Size(413, 39);
            this.txtCantCuerdas.TabIndex = 9;
            this.txtCantCuerdas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantCuerdas_KeyPress);
            // 
            // lblCantidadCuerdas
            // 
            this.lblCantidadCuerdas.AutoSize = true;
            this.lblCantidadCuerdas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblCantidadCuerdas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadCuerdas.Location = new System.Drawing.Point(23, 486);
            this.lblCantidadCuerdas.Name = "lblCantidadCuerdas";
            this.lblCantidadCuerdas.Size = new System.Drawing.Size(134, 28);
            this.lblCantidadCuerdas.TabIndex = 22;
            this.lblCantidadCuerdas.Text = "Cant cuerdas";
            // 
            // lblTipoGuitarra
            // 
            this.lblTipoGuitarra.AutoSize = true;
            this.lblTipoGuitarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblTipoGuitarra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoGuitarra.Location = new System.Drawing.Point(21, 411);
            this.lblTipoGuitarra.Name = "lblTipoGuitarra";
            this.lblTipoGuitarra.Size = new System.Drawing.Size(136, 28);
            this.lblTipoGuitarra.TabIndex = 24;
            this.lblTipoGuitarra.Text = "Tipo guitarra";
            // 
            // cmbBoxTipoGuitarra
            // 
            this.cmbBoxTipoGuitarra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxTipoGuitarra.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxTipoGuitarra.FormattingEnabled = true;
            this.cmbBoxTipoGuitarra.Location = new System.Drawing.Point(21, 443);
            this.cmbBoxTipoGuitarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBoxTipoGuitarra.Name = "cmbBoxTipoGuitarra";
            this.cmbBoxTipoGuitarra.Size = new System.Drawing.Size(413, 39);
            this.cmbBoxTipoGuitarra.TabIndex = 8;
            // 
            // FrmGuitarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 643);
            this.Controls.Add(this.cmbBoxTipoGuitarra);
            this.Controls.Add(this.lblTipoGuitarra);
            this.Controls.Add(this.lblCantidadCuerdas);
            this.Controls.Add(this.txtCantCuerdas);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmGuitarra";
            this.Text = "FrmGuitarra";
            this.Load += new System.EventHandler(this.FrmGuitarra_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.cmbBoxOrigen, 0);
            this.Controls.SetChildIndex(this.grpBoxEsUsado, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.txtPorcentaje, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.Controls.SetChildIndex(this.txtCantCuerdas, 0);
            this.Controls.SetChildIndex(this.lblCantidadCuerdas, 0);
            this.Controls.SetChildIndex(this.lblTipoGuitarra, 0);
            this.Controls.SetChildIndex(this.cmbBoxTipoGuitarra, 0);
            this.grpBoxEsUsado.ResumeLayout(false);
            this.grpBoxEsUsado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantidadCuerdas;
        private System.Windows.Forms.Label lblTipoGuitarra;
        public System.Windows.Forms.TextBox txtCantCuerdas;
        private System.Windows.Forms.ComboBox cmbBoxTipoGuitarra;
    }
}