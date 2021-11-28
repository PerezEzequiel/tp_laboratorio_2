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
    public partial class FrmMuestraYSeleccion : Form
    {
        private Local<Instrumento> miLocal;
        private int codigo;
        private EClasificacion clasificacion;
        
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }
        public EClasificacion Clasificacion
        {
            get
            {
                return this.clasificacion;
            }
        }
        
        public FrmMuestraYSeleccion(Local<Instrumento> local)
        {
            InitializeComponent();
            miLocal = local;
        }

        private void FrmMuestraYseleccion_Load(object sender, EventArgs e)
        {
            this.cmbClasificacion.DataSource = Enum.GetValues(typeof(EClasificacion));
            this.cmbClasificacion.SelectedIndex = 0;
           this.rchTxtInformacion.Text = Local<Instrumento>.MostrarStock(miLocal);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int numeroEnteroValidacion;
            bool rta = int.TryParse(this.txtCodigo.Text,out numeroEnteroValidacion);

            if (rta != false)
            {
                this.codigo = numeroEnteroValidacion;
                this.DialogResult = DialogResult.OK;
                this.clasificacion = (EClasificacion)this.cmbClasificacion.SelectedItem;
            }
            else
            {
                MessageBox.Show("Hubo un error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
