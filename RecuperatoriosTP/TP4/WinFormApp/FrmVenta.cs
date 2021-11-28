using Entidades;
using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FrmVenta : Form
    {
        private Local<Instrumento> miLocal;
        private Instrumento instrumentoFrmVenta;

        public Instrumento InstrumentoFrmVenta
        {
            
            get
            {
                return this.instrumentoFrmVenta;
            }
        }

        public FrmVenta(Local<Instrumento> local)
        {
            InitializeComponent();
            miLocal = local;

        }
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.txtCodigo.Text = "";
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int codigo;
            bool codigoVal = int.TryParse(this.txtCodigo.Text, out codigo);
            Instrumento miInstrumento;

            miInstrumento = miLocal | codigo;

            if (codigoVal != false && miInstrumento is not null && miLocal - miInstrumento)
            {
                this.instrumentoFrmVenta = miInstrumento;
                MessageBox.Show("Venta hecha con exito.", "Venta OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No existe un instrumento con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVenta_Paint(object sender, PaintEventArgs e)
        {
            this.rchTxtStock.Text = Local<Instrumento>.MostrarStock(miLocal);
        }

        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
