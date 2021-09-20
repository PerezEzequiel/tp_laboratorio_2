using Entidades;
using System;
using System.Text;
using System.Windows.Forms;



namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Se encarga de dejar vacio todas las propiedades del formulario(TextBox,Label,ComboBox).
        /// </summary>
        private void Limpiar()
        {
            this.textNumero1.Text = "";
            this.textNumero2.Text = "";
            this.lblResultado.Text = "";
            this.cmbOperador.SelectedItem = "";
        }


        /// <summary>
        /// Ciclo de vida Load, se encarga de llamar al metodo Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }


        /// <summary>
        /// Evento click del boton limpiar, se encarga de llamar al metodo Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Se encarga de realizar una operacion(a traves del metodo Operar de la clase Calculadora) y retornarlo.
        /// </summary>
        /// <param name="numero1">Numero recibido como string.</param>
        /// <param name="numero2">Numero recibido como string.</param>
        /// <param name="operador">Operador recibido como string.</param>
        /// <returns>Retorna el resultado obtenido.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;
            char auxOperador;
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);

            char.TryParse(operador, out auxOperador);
            resultado = Calculadora.Operar(num1, num2, auxOperador);

            return resultado;
        }


        /// <summary>
        /// Evento click del boton operar, se encarga de hacer la llamada a el metodo  Operar y en caso de no haber ningun error, el resultado obtenido se asigna a un listBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            StringBuilder operacion = new StringBuilder();
            string numero1 = this.textNumero1.Text;
            string numero2 = this.textNumero2.Text;
            string operador = this.cmbOperador.SelectedItem.ToString();

            double resultadoRecibido = FormCalculadora.Operar(numero1, numero2, operador);

            if (numero1 != "" && numero2 != "")
            {
                if (operador == "")
                {
                    operador = "+";
                }
                if (resultadoRecibido == double.MinValue)
                {
                    MessageBox.Show("Hubo un error, usted ingreso un 0 como segundo operando.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                operacion.AppendLine(numero1 + operador + numero2 + ' ' + "= " + resultadoRecibido);
                this.lstOperaciones.Items.Add(operacion.ToString());
                this.lblResultado.Text = resultadoRecibido.ToString();
            }
            else
            {
                MessageBox.Show("Primero cargue todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        
        /// <summary>
        /// Evento click del boton cerrar, se encarga de llamar al metodo Close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convierte un valor a binario y se lo asigna al label "lblResultado" en caso de que haya algun error, el valor final sera "Valor invalido".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            string auxiliar = operando.DecimalBinario(lblResultado.Text);

            if (auxiliar == "Valor invalido")
            {
                MessageBox.Show("Cargue un resultado valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            this.lblResultado.Text= auxiliar;

        }


        /// <summary>
        /// Convierte un valor a decimal y se lo asigna al label "lblResultado" en caso de que haya algun error, el valor final sera "Valor invalido".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            string auxiliar = operando.BinarioDecimal(this.lblResultado.Text);

            if (auxiliar == "Valor invalido")
            {
                MessageBox.Show("Cargue un resultado valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            this.lblResultado.Text = auxiliar;
        }

        /// <summary>
        /// Ciclo de vida closing, permite cancelar el cierre segun la respuesta del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
