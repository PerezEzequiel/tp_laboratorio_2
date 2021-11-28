using Entidades;
using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FrmInstrumento : Form
    {
        public FrmInstrumento()
        {
            InitializeComponent();
        }
        public virtual Instrumento InstrumentoFrm
        {
            get;
        }

        protected void Limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtCosto.Text = "";
            this.txtMarca.Text = "";
            this.txtModelo.Text = "";
            this.txtPorcentaje.Text = "";
            this.cmbBoxOrigen.SelectedIndex = 0;
        }
        private void FrmInstrumento_Load(object sender, EventArgs e)
        {
            if(this.cmbBoxOrigen.Items.Count == 0)
            {
                foreach (EOrigen item in Enum.GetValues(typeof(EOrigen)))
                {
                    if (item != EOrigen.Todos)
                    {
                        this.cmbBoxOrigen.Items.Add(item);
                    }
                }
            }

            this.radioBtnSi.Checked = true;
        }

        public virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        protected void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }
    }
}
