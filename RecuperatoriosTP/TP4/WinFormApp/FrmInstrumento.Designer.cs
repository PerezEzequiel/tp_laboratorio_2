
namespace WinFormApp
{
    partial class FrmInstrumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInstrumento));
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbBoxOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.grpBoxEsUsado = new System.Windows.Forms.GroupBox();
            this.radioBtnNo = new System.Windows.Forms.RadioButton();
            this.radioBtnSi = new System.Windows.Forms.RadioButton();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpBoxEsUsado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.txtMarca.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMarca.Location = new System.Drawing.Point(14, 175);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(420, 39);
            this.txtMarca.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.txtModelo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModelo.Location = new System.Drawing.Point(12, 274);
            this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(420, 39);
            this.txtModelo.TabIndex = 3;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(6)))));
            this.lblMarca.Location = new System.Drawing.Point(12, 140);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(80, 31);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(6)))));
            this.lblModelo.Location = new System.Drawing.Point(12, 239);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(97, 31);
            this.lblModelo.TabIndex = 7;
            this.lblModelo.Text = "Modelo";
            // 
            // cmbBoxOrigen
            // 
            this.cmbBoxOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.cmbBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxOrigen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxOrigen.FormattingEnabled = true;
            this.cmbBoxOrigen.Location = new System.Drawing.Point(12, 396);
            this.cmbBoxOrigen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBoxOrigen.Name = "cmbBoxOrigen";
            this.cmbBoxOrigen.Size = new System.Drawing.Size(420, 39);
            this.cmbBoxOrigen.TabIndex = 4;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblOrigen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrigen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(6)))));
            this.lblOrigen.Location = new System.Drawing.Point(14, 341);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(87, 31);
            this.lblOrigen.TabIndex = 9;
            this.lblOrigen.Text = "Origen";
            // 
            // grpBoxEsUsado
            // 
            this.grpBoxEsUsado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.grpBoxEsUsado.Controls.Add(this.radioBtnNo);
            this.grpBoxEsUsado.Controls.Add(this.radioBtnSi);
            this.grpBoxEsUsado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(6)))));
            this.grpBoxEsUsado.Location = new System.Drawing.Point(14, 475);
            this.grpBoxEsUsado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxEsUsado.Name = "grpBoxEsUsado";
            this.grpBoxEsUsado.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxEsUsado.Size = new System.Drawing.Size(178, 65);
            this.grpBoxEsUsado.TabIndex = 5;
            this.grpBoxEsUsado.TabStop = false;
            this.grpBoxEsUsado.Text = "Es usado";
            // 
            // radioBtnNo
            // 
            this.radioBtnNo.AutoSize = true;
            this.radioBtnNo.Location = new System.Drawing.Point(93, 29);
            this.radioBtnNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnNo.Name = "radioBtnNo";
            this.radioBtnNo.Size = new System.Drawing.Size(50, 24);
            this.radioBtnNo.TabIndex = 7;
            this.radioBtnNo.TabStop = true;
            this.radioBtnNo.Text = "No";
            this.radioBtnNo.UseVisualStyleBackColor = true;
            // 
            // radioBtnSi
            // 
            this.radioBtnSi.AutoSize = true;
            this.radioBtnSi.Location = new System.Drawing.Point(7, 29);
            this.radioBtnSi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioBtnSi.Name = "radioBtnSi";
            this.radioBtnSi.Size = new System.Drawing.Size(42, 24);
            this.radioBtnSi.TabIndex = 6;
            this.radioBtnSi.TabStop = true;
            this.radioBtnSi.Text = "Si";
            this.radioBtnSi.UseVisualStyleBackColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoEllipsis = true;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(6)))));
            this.lblCodigo.Location = new System.Drawing.Point(12, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(91, 31);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(12, 88);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(420, 39);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtCosto
            // 
            this.txtCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.txtCosto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCosto.Location = new System.Drawing.Point(590, 318);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(420, 39);
            this.txtCosto.TabIndex = 13;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblCosto.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCosto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(6)))));
            this.lblCosto.Location = new System.Drawing.Point(590, 283);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(75, 31);
            this.lblCosto.TabIndex = 14;
            this.lblCosto.Text = "Costo";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.txtPorcentaje.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPorcentaje.Location = new System.Drawing.Point(590, 396);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(420, 39);
            this.txtPorcentaje.TabIndex = 15;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(6)))));
            this.lblPorcentaje.Location = new System.Drawing.Point(590, 361);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(127, 31);
            this.lblPorcentaje.TabIndex = 17;
            this.lblPorcentaje.Text = "Porcentaje";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(85)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(654, 600);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(180, 67);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(88)))), ((int)(((byte)(90)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(840, 600);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(179, 67);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmInstrumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1031, 680);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbBoxOrigen);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.grpBoxEsUsado);
            this.Controls.Add(this.lblOrigen);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmInstrumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga instrumento";
            this.Load += new System.EventHandler(this.FrmInstrumento_Load);
            this.grpBoxEsUsado.ResumeLayout(false);
            this.grpBoxEsUsado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.TextBox txtMarca;
        protected System.Windows.Forms.TextBox txtModelo;
        protected System.Windows.Forms.ComboBox cmbBoxOrigen;
        protected System.Windows.Forms.GroupBox grpBoxEsUsado;
        protected System.Windows.Forms.RadioButton radioBtnNo;
        protected System.Windows.Forms.RadioButton radioBtnSi;
        protected System.Windows.Forms.TextBox txtCosto;
        protected System.Windows.Forms.TextBox txtPorcentaje;
        protected System.Windows.Forms.TextBox txtCodigo;
        protected System.Windows.Forms.Button btnAceptar;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Label lblMarca;
        protected System.Windows.Forms.Label lblModelo;
        protected System.Windows.Forms.Label lblOrigen;
        protected System.Windows.Forms.Label lblCodigo;
        protected System.Windows.Forms.Label lblCosto;
        protected System.Windows.Forms.Label lblPorcentaje;
    }
}