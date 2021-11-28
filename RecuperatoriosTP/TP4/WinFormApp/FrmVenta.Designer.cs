
namespace WinFormApp
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.rchTxtStock = new System.Windows.Forms.RichTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoInstrumento = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchTxtStock
            // 
            this.rchTxtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.rchTxtStock.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rchTxtStock.Location = new System.Drawing.Point(310, 16);
            this.rchTxtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rchTxtStock.Name = "rchTxtStock";
            this.rchTxtStock.Size = new System.Drawing.Size(706, 753);
            this.rchTxtStock.TabIndex = 0;
            this.rchTxtStock.Text = "";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(14, 296);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(289, 41);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigoInstrumento
            // 
            this.lblCodigoInstrumento.AutoSize = true;
            this.lblCodigoInstrumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(106)))), ((int)(((byte)(141)))));
            this.lblCodigoInstrumento.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoInstrumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.lblCodigoInstrumento.Location = new System.Drawing.Point(14, 267);
            this.lblCodigoInstrumento.Name = "lblCodigoInstrumento";
            this.lblCodigoInstrumento.Size = new System.Drawing.Size(298, 25);
            this.lblCodigoInstrumento.TabIndex = 2;
            this.lblCodigoInstrumento.Text = "Ingrese el codigo del instrumento";
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(166)))), ((int)(((byte)(216)))));
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVender.Location = new System.Drawing.Point(14, 365);
            this.btnVender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(139, 45);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(27)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(163, 365);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 44.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(242)))));
            this.lblTitulo.Location = new System.Drawing.Point(31, 112);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 100);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Venta";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1030, 787);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblCodigoInstrumento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.rchTxtStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVenta_FormClosing);
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmVenta_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtStock;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoInstrumento;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
    }
}