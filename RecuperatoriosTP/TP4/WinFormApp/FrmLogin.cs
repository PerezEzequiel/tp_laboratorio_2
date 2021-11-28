using Entidades;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FrmLogin : Form
    {
        private Local<Instrumento> local;
        FrmPrincipal frmPrincipal;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double capital;
            bool capitalVal = double.TryParse(this.txtCapital.Text, out capital);

            int capacidad;
            bool capacidadVal = int.TryParse(this.txtCapacidad.Text, out capacidad);


            try
            {
                if (capitalVal != false && capacidadVal != false && this.txtNombreLocal.Text != string.Empty && this.txtDireccion.Text != string.Empty)
                {
                    local = new Local<Instrumento>(capacidad, this.txtNombreLocal.Text, this.txtDireccion.Text, capital);

                    Task task = Task.Run(() => local.Stock = local.ObtenerTodos());
                    
                    frmPrincipal = new FrmPrincipal(local);
                    this.Hide();
                    if (frmPrincipal.ShowDialog() == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cargue correctamente los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
