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
    public partial class FrmVenta : Form
    {
        Local<Instrumento> miLocal;
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

            if(codigoVal != false && miInstrumento is not null && miLocal - miInstrumento)
            {
                MessageBox.Show("Venta hecha con exito.","Venta OK",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}
