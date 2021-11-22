using Entidades;
using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FrmBateria : FrmInstrumento
    {
        private Bateria bateriaForm;
        public FrmBateria()
        {
            InitializeComponent();
        }

        public override Instrumento InstrumentoFrm
        {
            get
            {
                return this.bateriaForm;
            }
        }

        public override void btnAceptar_Click(object sender, EventArgs e)
        {
            int cantCuerpos;
            bool cantCuerdasVal = int.TryParse(this.txtCantidadCuerpos.Text, out cantCuerpos);

            double costo;
            bool costoVal = double.TryParse(this.txtCosto.Text, out costo);

            int codigo;
            bool codigoVal = int.TryParse(this.txtCodigo.Text, out codigo);

            int porcentajeGanancia;
            bool porcentajeGananciaVal = int.TryParse(this.txtPorcentaje.Text, out porcentajeGanancia);

            bool esUsado = this.radioBtnSi.Checked;

            try
            {
                if (cantCuerdasVal != false && costoVal != false && porcentajeGananciaVal != false && codigoVal != false && this.txtMarca.Text != String.Empty && this.txtModelo.Text != String.Empty)
                {
                    bateriaForm = new Bateria(cantCuerpos, codigo, costo, this.txtMarca.Text, this.txtModelo.Text, esUsado, porcentajeGanancia, (EOrigen)this.cmbBoxOrigen.SelectedItem);
                    base.btnAceptar_Click(sender, e);
                    MessageBox.Show(bateriaForm.ToString());
                }
            }
            catch (CampoInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtCantidadCuerpos_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarNumero(sender, e);
        }

        private void FrmBateria_Load(object sender, EventArgs e)
        {
            base.Limpiar();
            this.txtCantidadCuerpos.Text = "";
        }
    }
}
