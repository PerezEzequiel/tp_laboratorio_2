
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
            this.cmbBoxOrigen.Size = new System.Drawing.Size(420, 39);
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
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClave.Location = new System.Drawing.Point(14, 452);
            this.txtClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(420, 39);
            this.txtClave.TabIndex = 20;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClave.Location = new System.Drawing.Point(14, 420);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(63, 28);
            this.lblClave.TabIndex = 21;
            this.lblClave.Text = "Clave";
            // 
            // FrmTrompeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 651);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmTrompeta";
            this.Text = "FrmTrompeta";
            this.Load += new System.EventHandler(this.FrmTrompeta_Load);
            this.Controls.SetChildIndex(this.txtMarca, 0);
            this.Controls.SetChildIndex(this.txtModelo, 0);
            this.Controls.SetChildIndex(this.cmbBoxOrigen, 0);
            this.Controls.SetChildIndex(this.grpBoxEsUsado, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.Controls.SetChildIndex(this.txtPorcentaje, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.lblClave, 0);
            this.grpBoxEsUsado.ResumeLayout(false);
            this.grpBoxEsUsado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
    }
}