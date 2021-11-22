using Entidades;
using System;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class FrmEmpleado : Form
    {
        private Empleado miEmpleado;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        public Empleado Empleado
        {
            get
            {
                return this.miEmpleado;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double salario;
            bool salarioVal = double.TryParse(this.txtSalario.Text, out salario);

            int DNI;
            bool DniValidacion = int.TryParse(this.txtDni.Text, out DNI);


            try
            {
                if (this.txtApellido.Text != string.Empty && this.txtNombre.Text != string.Empty && salarioVal != false && DniValidacion != false)
                {
                    miEmpleado = new Empleado(DNI, this.txtNombre.Text, this.txtApellido.Text, salario, (ETipoEmpleado)this.cmbTipoEmpleado.SelectedItem, this.dateTimePickerFechaIngreso.Value);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Cargue correctamente los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarNumero(sender, e);
        }

        private void ValidarNumero(object sender, KeyPressEventArgs e)
        {
            char letra = e.KeyChar;
            if (!char.IsDigit(letra) && letra != 8)
            {
                e.Handled = true;
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            this.cmbTipoEmpleado.DataSource = Enum.GetValues(typeof(ETipoEmpleado));
        }
    }
}
