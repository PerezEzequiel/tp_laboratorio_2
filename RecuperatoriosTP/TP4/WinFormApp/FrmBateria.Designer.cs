
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
            this.txtMarca.Location = new System.Drawing.Point(12, 264);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(12, 396);
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
            this.cmbBoxOrigen.Location = new System.Drawing.Point(12, 536);
            this.cmbBoxOrigen.Size = new System.Drawing.Size(420, 39);
            // 
            // grpBoxEsUsado
            // 
            this.grpBoxEsUsado.Location = new System.Drawing.Point(12, 627);
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
            this.txtCosto.Location = new System.Drawing.Point(590, 396);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCosto.TabIndex = 7;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(590, 536);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPorcentaje.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 130);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(678, 732);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(879, 732);
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
            this.lblCosto.Location = new System.Drawing.Point(590, 343);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Location = new System.Drawing.Point(590, 477);
            // 
            // txtCantidadCuerpos
            // 
            this.txtCantidadCuerpos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadCuerpos.Location = new System.Drawing.Point(590, 264);
            this.txtCantidadCuerpos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidadCuerpos.Name = "txtCantidadCuerpos";
            this.txtCantidadCuerpos.Size = new System.Drawing.Size(420, 39);
            this.txtCantidadCuerpos.TabIndex = 6;
            this.txtCantidadCuerpos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadCuerpos_KeyPress);
            // 
            // lblCantidadCuerpos
            // 
            this.lblCantidadCuerpos.AutoSize = true;
            this.lblCantidadCuerpos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblCantidadCuerpos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadCuerpos.Location = new System.Drawing.Point(590, 211);
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
            this.lblTitulo.Location = new System.Drawing.Point(456, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(158, 54);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Bateria";
            // 
            // FrmBateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 812);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCantidadCuerpos);
            this.Controls.Add(this.txtCantidadCuerpos);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmBateria";
            this.Text = "Carga bateria";
            this.Load += new System.EventHandler(this.FrmBateria_Load);
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