
namespace WinFormApp
{
    partial class FrmTrompeta
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
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(590, 536);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.btnCancelar.Location = new System.Drawing.Point(888, 732);
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
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClave.Location = new System.Drawing.Point(590, 264);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(420, 39);
            this.txtClave.TabIndex = 20;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClave.Location = new System.Drawing.Point(590, 208);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(69, 30);
            this.lblClave.TabIndex = 21;
            this.lblClave.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(418, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Trompeta";
            // 
            // FrmTrompeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 812);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmTrompeta";
            this.Text = "Carga trompeta";
            this.Load += new System.EventHandler(this.FrmTrompeta_Load);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.lblClave, 0);
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
            this.Controls.SetChildIndex(this.label1, 0);
            this.grpBoxEsUsado.ResumeLayout(false);
            this.grpBoxEsUsado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label label1;
    }
}