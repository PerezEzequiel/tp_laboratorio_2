
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
            this.txtMarca.Location = new System.Drawing.Point(12, 264);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 396);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // grpBoxEsUsado
            // 
            this.grpBoxEsUsado.Location = new System.Drawing.Point(12, 627);
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.TabIndex = 6;
            this.radioBtnNo.TabStop = false;
            // 
            // radioBtnSi
            // 
            this.radioBtnSi.Checked = true;
            this.radioBtnSi.TabIndex = 5;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(587, 396);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCosto.TabIndex = 9;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(587, 536);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPorcentaje.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 130);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(688, 735);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(899, 735);
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(12, 208);
            // 
            // lblModelo
            // 
            this.lblModelo.Location = new System.Drawing.Point(12, 343);
            // 
            // lblOrigen
            // 
            this.lblOrigen.Location = new System.Drawing.Point(12, 477);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(12, 85);
            // 
            // lblCosto
            // 
            this.lblCosto.Location = new System.Drawing.Point(587, 360);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Location = new System.Drawing.Point(590, 477);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(431, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 59);
            this.lblTitulo.TabIndex = 20;
            this.lblTitulo.Text = "Guitarra";
            // 
            // txtCantCuerdas
            // 
            this.txtCantCuerdas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantCuerdas.Location = new System.Drawing.Point(587, 264);
            this.txtCantCuerdas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantCuerdas.Name = "txtCantCuerdas";
            this.txtCantCuerdas.Size = new System.Drawing.Size(413, 39);
            this.txtCantCuerdas.TabIndex = 8;
            this.txtCantCuerdas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantCuerdas_KeyPress);
            // 
            // lblCantidadCuerdas
            // 
            this.lblCantidadCuerdas.AutoSize = true;
            this.lblCantidadCuerdas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblCantidadCuerdas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadCuerdas.Location = new System.Drawing.Point(590, 228);
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
            this.lblTipoGuitarra.Location = new System.Drawing.Point(587, 85);
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
            this.cmbBoxTipoGuitarra.Location = new System.Drawing.Point(587, 130);
            this.cmbBoxTipoGuitarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBoxTipoGuitarra.Name = "cmbBoxTipoGuitarra";
            this.cmbBoxTipoGuitarra.Size = new System.Drawing.Size(413, 39);
            this.cmbBoxTipoGuitarra.TabIndex = 7;
            // 
            // FrmGuitarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 812);
            this.Controls.Add(this.cmbBoxTipoGuitarra);
            this.Controls.Add(this.lblTipoGuitarra);
            this.Controls.Add(this.lblCantidadCuerdas);
            this.Controls.Add(this.txtCantCuerdas);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmGuitarra";
            this.Text = "Carga guitarra";
            this.Load += new System.EventHandler(this.FrmGuitarra_Load);
            this.Controls.SetChildIndex(this.lblMarca, 0);
            this.Controls.SetChildIndex(this.lblModelo, 0);
            this.Controls.SetChildIndex(this.lblOrigen, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.lblCosto, 0);
            this.Controls.SetChildIndex(this.lblPorcentaje, 0);
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