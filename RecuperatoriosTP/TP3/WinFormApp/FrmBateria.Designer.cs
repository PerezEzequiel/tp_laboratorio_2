
namespace WinFormApp
{
    partial class FrmBateria
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
            this.txtCantidadCuerpos = new System.Windows.Forms.TextBox();
            this.lblCantidadCuerpos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
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
            this.grpBoxEsUsado.TabIndex = 4;
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
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCosto.TabIndex = 8;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPorcentaje.TabIndex = 9;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // txtCantidadCuerpos
            // 
            this.txtCantidadCuerpos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadCuerpos.Location = new System.Drawing.Point(12, 468);
            this.txtCantidadCuerpos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidadCuerpos.Name = "txtCantidadCuerpos";
            this.txtCantidadCuerpos.Size = new System.Drawing.Size(420, 39);
            this.txtCantidadCuerpos.TabIndex = 7;
            this.txtCantidadCuerpos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadCuerpos_KeyPress);
            // 
            // lblCantidadCuerpos
            // 
            this.lblCantidadCuerpos.AutoSize = true;
            this.lblCantidadCuerpos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblCantidadCuerpos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadCuerpos.Location = new System.Drawing.Point(12, 436);
            this.lblCantidadCuerpos.Name = "lblCantidadCuerpos";
            this.lblCantidadCuerpos.Size = new System.Drawing.Size(205, 28);
            this.lblCantidadCuerpos.TabIndex = 21;
            this.lblCantidadCuerpos.Text = "Cantidad de cuerpos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(369, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 54);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Bateria";
            // 
            // FrmBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 643);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCantidadCuerpos);
            this.Controls.Add(this.txtCantidadCuerpos);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBateria";
            this.Text = "FrmBateria";
            this.Load += new System.EventHandler(this.FrmBateria_Load);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.cmbBoxOrigen, 0);
            this.Controls.SetChildIndex(this.grpBoxEsUsado, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.txtPorcentaje, 0);
            this.Controls.SetChildIndex(this.txtCantidadCuerpos, 0);
            this.Controls.SetChildIndex(this.lblCantidadCuerpos, 0);
            this.Controls.SetChildIndex(this.lblTitulo, 0);
            this.grpBoxEsUsado.ResumeLayout(false);
            this.grpBoxEsUsado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidadCuerpos;
        private System.Windows.Forms.Label lblCantidadCuerpos;
        private System.Windows.Forms.Label lblTitulo;
    }
}