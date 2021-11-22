using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinFormApp
{
    public partial class FrmTrompeta : FrmInstrumento
    {
        public FrmTrompeta()
        {
            InitializeComponent();
        }
        private Trompeta TrompetaForm;
        public override Instrumento InstrumentoFrm
        {
            get
            {
                return this.TrompetaForm;
            }
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            double costo;
            bool costoVal = double.TryParse(this.txtCosto.Text, out costo);

            int codigo;
            bool codigoVal = int.TryParse(this.txtCodigo.Text, out codigo);

            int porcentajeGanancia;
            bool porcentajeGananciaVal = int.TryParse(this.txtPorcentaje.Text, out porcentajeGanancia);

            bool esUsado = this.radioBtnSi.Checked;

            try
            {
                if (costoVal != false && porcentajeGananciaVal != false && codigoVal != false && this.txtMarca.Text != String.Empty && this.txtModelo.Text != String.Empty && this.txtClave.Text != String.Empty)
                {
                    TrompetaForm = new Trompeta(this.txtClave.Text,codigo, costo, this.txtMarca.Text, this.txtModelo.Text, esUsado, porcentajeGanancia, (EOrigen)this.cmbBoxOrigen.SelectedItem);
                    base.btnAceptar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Cargue TODOS los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCantidadCuerpos_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarNumero(sender, e);
        }

        private void FrmTrompeta_Load(object sender, EventArgs e)
        {
            base.Limpiar();
            this.txtClave.Text = "";
        }
    }
}
