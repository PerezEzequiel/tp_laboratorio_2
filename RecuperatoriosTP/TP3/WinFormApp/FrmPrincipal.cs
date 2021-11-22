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
    public partial class FrmPrincipal : Form
    {
        private Local<Instrumento> miLocal;
        private FrmSeleccion frmSeleccion;
        private FrmVenta frmVenta;
        private FrmEmpleado frmEmpleado;
        private FrmEstadistica frmEstadistica;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Xml miXml;
        private ArchivoTexto miArchivoTexto;
        public FrmPrincipal(Local<Instrumento> local)
        {
            InitializeComponent();
            miLocal = local;
            frmSeleccion = new FrmSeleccion();
            frmVenta = new FrmVenta(miLocal);
            frmEmpleado = new FrmEmpleado();
            frmEstadistica = new FrmEstadistica();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            miXml = new Xml();
            miArchivoTexto = new ArchivoTexto();
        }

        public void Limpiar()
        {
            this.rchTxtInformacion.Text = "";
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.lblInfoMuestra.Text = "Stock";
            this.rchTxtInformacion.Text = Local<Instrumento>.MostrarStock(miLocal);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.lblInfoMuestra.Text = "Ventas";
            this.rchTxtInformacion.Text = Local<Instrumento>.MostrarVentas(miLocal);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.lblInfoMuestra.Text = "Empleados";
            this.rchTxtInformacion.Text = Local<Instrumento>.MostrarEmpleados(miLocal);
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if(this.miLocal.Stock.Count < this.miLocal.CapacidadMaxima )
            {
                if (frmSeleccion.ShowDialog() == DialogResult.OK)
                {
                    if (this.miLocal + frmSeleccion.instrumentoFrm)
                    {
                        MessageBox.Show("Agregado!","OK",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No se agrego al stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay mas capacidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnVenta_Click(object sender, EventArgs e)
        {
            if(this.miLocal.Stock.Count > 0)
            {
                frmVenta.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmPrincipal_Paint(object sender, PaintEventArgs e)
        {
            this.txtCapital.Text = miLocal.Capital.ToString();
            this.txtGanancias.Text = miLocal.Ganancias.ToString();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            if(this.miLocal.Ganancias > 0)
            {
                try
                {
                    if (frmEmpleado.ShowDialog() == DialogResult.OK && Local<Instrumento>.AgregarEmpleado(miLocal, frmEmpleado.Empleado))
                    {
                        MessageBox.Show("Agregado!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        MessageBox.Show("No se agrego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No hay ganancias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if(frmEstadistica.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (frmEstadistica.MiEstadistica)
                    {
                        case EMisEstadisticas.PorcentajeClasificacionInstrumentosEnStock:
                            this.lblInfoMuestra.Text = "Porcentaje de instrumentos en Stock";
                            this.rchTxtInformacion.Text = miLocal.InformacionPorcentajeTotalStock;
                            break;
                        case EMisEstadisticas.PorcentajeClasificacionInstrumentosEnVentas:
                            this.lblInfoMuestra.Text = "Porcentaje de instrumentos en ventas";
                            this.rchTxtInformacion.Text = miLocal.PorcentajeTotalVentas;
                            break;
                        case EMisEstadisticas.PromedioMasVendidoSegunPais:
                            this.lblInfoMuestra.Text = "Porcentaje de instrumentos por pais";
                            this.rchTxtInformacion.Text = miLocal.PorcentajeInstrumentosSegunPais;

                            break;
                        case EMisEstadisticas.PromedioSalarioEmpleados:
                            this.rchTxtInformacion.Text = miLocal.PromedioSalarioEmpleados;
                            break;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error al calcular las estadisticas.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string xml = "Archivo XML (*.xml)|*.xml";
            string texto = "Archivo de texto (*.txt)|*.txt";
            this.saveFileDialog.Title = "Exportar";

            switch (this.lblInfoMuestra.Text)
            {
                case "Stock":
                    this.saveFileDialog.Filter = xml;
                    break;
                case "Ventas":
                    this.saveFileDialog.Filter = xml;
                    break;
                case "Empleados":
                    this.saveFileDialog.Filter = xml;
                    break;
;                default:
                    this.saveFileDialog.Filter = texto;
                    break;
            }

            if (this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (this.lblInfoMuestra.Text)
                    {
                        case "Stock":
                            if (miXml.Guardar<List<Instrumento>>(miLocal.Stock, this.saveFileDialog.FileName))
                            {
                                MessageBox.Show("Stock Guardado\nruta: {this.saveFileDialog.FileName}");
                            }
                            break;
                        case "Ventas":
                            if (miXml.Guardar<List<Instrumento>>(miLocal.Ventas, this.saveFileDialog.FileName))
                            {
                                MessageBox.Show($"Ventas Guardadas\nruta: {this.saveFileDialog.FileName}");
                            }
                            break;
                        case "Empleados":
                            if (miXml.Guardar<List<Empleado>>(miLocal.Empleados, this.saveFileDialog.FileName))
                            {
                                MessageBox.Show($"Empleados Guardados\nruta: {this.saveFileDialog.FileName}");
                            }
                            break;
                        default:
                            if(miArchivoTexto.Guardar<string>(this.rchTxtInformacion.Text, this.saveFileDialog.FileName))
                            {
                                MessageBox.Show($"Archivo de texto Guardado\nruta: {this.saveFileDialog.FileName}");
                            }
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string xml = "Archivo XML (*.xml)|*.xml";
            this.saveFileDialog.Title = "Importar";
            this.openFileDialog.Filter = xml;
            List<Instrumento> auxiliar = new List<Instrumento>();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    switch (this.lblInfoMuestra.Text)
                    {
                        case "Stock":
                            if ((auxiliar = miXml.Abrir<List<Instrumento>>(openFileDialog.FileName)) != null && auxiliar.Count <= this.miLocal.CapacidadMaxima)
                            {
                                this.miLocal.Stock = auxiliar;
                                MessageBox.Show("Stock agregado");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case "Ventas":
                            if ((this.miLocal.Ventas = miXml.Abrir<List<Instrumento>>(openFileDialog.FileName)) != null)
                            {
                                MessageBox.Show("Ventas agregada");
                            }
                            break;
                        case "Empleados":
                            if ((this.miLocal.Empleados = miXml.Abrir<List<Empleado>>(openFileDialog.FileName)) != null)
                            {
                                MessageBox.Show("Empleados agregados");
                            }
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }

            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.lblInformacion.Text = miLocal.Informacion;
        }
    }
}
