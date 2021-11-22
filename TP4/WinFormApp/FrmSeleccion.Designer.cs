
namespace WinFormApp
{
    partial class FrmSeleccion
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
            this.btnGuitarra = new System.Windows.Forms.Button();
            this.btnBateria = new System.Windows.Forms.Button();
            this.btnTrompeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGuitarra
            // 
            this.btnGuitarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(93)))), ((int)(((byte)(81)))));
            this.btnGuitarra.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuitarra.Location = new System.Drawing.Point(-1, 40);
            this.btnGuitarra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuitarra.Name = "btnGuitarra";
            this.btnGuitarra.Size = new System.Drawing.Size(302, 79);
            this.btnGuitarra.TabIndex = 0;
            this.btnGuitarra.Text = "Guitarra";
            this.btnGuitarra.UseVisualStyleBackColor = false;
            this.btnGuitarra.Click += new System.EventHandler(this.btnGuitarra_Click);
            // 
            // btnBateria
            // 
            this.btnBateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(169)))), ((int)(((byte)(199)))));
            this.btnBateria.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBateria.Location = new System.Drawing.Point(-1, 142);
            this.btnBateria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBateria.Name = "btnBateria";
            this.btnBateria.Size = new System.Drawing.Size(302, 79);
            this.btnBateria.TabIndex = 1;
            this.btnBateria.Text = "Bateria";
            this.btnBateria.UseVisualStyleBackColor = false;
            this.btnBateria.Click += new System.EventHandler(this.btnBateria_Click);
            // 
            // btnTrompeta
            // 
            this.btnTrompeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(84)))), ((int)(((byte)(102)))));
            this.btnTrompeta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTrompeta.Location = new System.Drawing.Point(-1, 247);
            this.btnTrompeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTrompeta.Name = "btnTrompeta";
            this.btnTrompeta.Size = new System.Drawing.Size(302, 79);
            this.btnTrompeta.TabIndex = 2;
            this.btnTrompeta.Text = "Trompeta";
            this.btnTrompeta.UseVisualStyleBackColor = false;
            this.btnTrompeta.Click += new System.EventHandler(this.btnTrompeta_Click);
            // 
            // FrmSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(300, 349);
            this.Controls.Add(this.btnTrompeta);
            this.Controls.Add(this.btnBateria);
            this.Controls.Add(this.btnGuitarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmSeleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSeleccion";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnGuitarra;
        protected System.Windows.Forms.Button btnBateria;
        protected System.Windows.Forms.Button btnTrompeta;
    }
}