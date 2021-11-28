using Entidades;
using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FrmGuitarra : FrmInstrumento
    {
        private Guitarra guitarraForm;
        public FrmGuitarra()
        {
            InitializeComponent();
        }

        public Guitarra GuitarraForm
        {
            get
            {
                return this.guitarraForm;
            }
        }
        public override Instrumento InstrumentoFrm
        {
            get
            {
                return this.guitarraForm;
            }
        }


        public override void btnAceptar_Click(object sender, EventArgs e)
        {

            int cantCuerdas;
            bool cantCuerdasVal = int.TryParse(this.txtCantCuerdas.Text, out cantCuerdas);

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
                    guitarraForm = new Guitarra(cantCuerdas, (ETipoGuitarra)this.cmbBoxTipoGuitarra.SelectedItem, costo, codigo, this.txtMarca.Text, this.txtModelo.Text, esUsado, porcentajeGanancia, (EOrigen)this.cmbBoxOrigen.SelectedItem);
                    base.btnAceptar_Click(sender,e);
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
        private void FrmGuitarra_Load(object sender, EventArgs e)
        {
            base.Limpiar();
            this.txtCantCuerdas.Text = "6";

            foreach (ETipoGuitarra item in Enum.GetValues(typeof(ETipoGuitarra)))
            {
                this.cmbBoxTipoGuitarra.Items.Add(item);
            }
            this.cmbBoxTipoGuitarra.SelectedIndex = 0;
        }

        private void txtCantCuerdas_KeyPress(object sender, KeyPressEventArgs e)
        {
            base.ValidarNumero(sender, e);
        }

    }
}
