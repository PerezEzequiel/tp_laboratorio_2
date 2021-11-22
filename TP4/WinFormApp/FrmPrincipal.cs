using Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{

    public delegate void DelegadoTaskParam(object param);
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

        private ADOGuitarra adoGuitarra;
        private ADOBateria adoBateria;
        private ADOTrompeta adoTrompeta;

        private FrmBateria frmBateria;
        private FrmGuitarra frmGuitarra;
        private FrmTrompeta frmTrompeta;

        private FrmMuestraYSeleccion frmMuestraYseleccion;

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
            adoGuitarra = new ADOGuitarra();
            adoBateria = new ADOBateria();
            adoTrompeta = new ADOTrompeta();
            frmMuestraYseleccion = new FrmMuestraYSeleccion(miLocal);
            frmBateria = new FrmBateria();
            frmGuitarra = new FrmGuitarra();
            frmTrompeta = new FrmTrompeta();
            this.btnAgregarStock.Click += btnAgregarStock_Click;
            local.eventoCargaError += this.MostrarErrorEvento;

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            this.lblInformacion.Text = miLocal.Informacion;
            this.InicializarManejador(sender, e);

        }

        public void InicializarManejador(object boton, EventArgs evento)
        {
            Color color = Color.Red;
            if (miLocal.Stock.Count > 0)
            {
                color = Color.Green;
            }
            foreach (Control item in this.Controls)
            {
                if (item is Button && this.btnAgregarStock != (Button)item && this.btnAgregarEmpleados != (Button)item)
                {
                    item.BackColor = color;
                }
            }
            if (miLocal.Ventas.Count > 0)
            {
                this.btnAgregarEmpleados.BackColor = Color.Green;
            }
        }
        public void Limpiar()
        {
            this.rchTxtInformacion.Text = "";
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.lblInfoMuestra.Text = "Stock";
            Task task = Task.Run(() => this.Mostrar(""));
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.lblInfoMuestra.Text = "Ventas";
            this.rchTxtInformacion.Text = Local<Instrumento>.MostrarVentas(miLocal);

        }

        private void Mostrar(object param)
        {
            StringBuilder sb = new StringBuilder();

            if (this.rchTxtInformacion.InvokeRequired)
            {
                DelegadoTaskParam delegado = new DelegadoTaskParam(Mostrar);
                this.Invoke(delegado, Local<Instrumento>.MostrarStock(miLocal));
            }
            else
            {
                this.rchTxtInformacion.Text = param.ToString();
            }
        }
        private void MostrarErrorEvento(object param, EventArgs e)
        {
            MessageBox.Show($"{param.ToString()}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Limpiar();
            this.lblInfoMuestra.Text = "Empleados";
            this.rchTxtInformacion.Text = Local<Instrumento>.MostrarEmpleados(miLocal);
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            Task guardadoBsd;
            Task taskCarga = Task.Run(() => miLocal += miLocal.ObtenerTodos());

            if (this.miLocal.Stock.Count < this.miLocal.CapacidadMaxima)
            {
                if (frmSeleccion.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (this.miLocal + frmSeleccion.instrumentoFrm)
                        {
                            switch (frmSeleccion.instrumentoFrm.TipoInstrumento)
                            {
                                case EClasificacion.Cuerda:
                                    guardadoBsd = Task.Run(() => adoGuitarra.AgregarGuitarra((Guitarra)frmSeleccion.instrumentoFrm));
                                    break;
                                case EClasificacion.Percusion:
                                    guardadoBsd = Task.Run(() => adoBateria.AgregarBateria((Bateria)frmSeleccion.instrumentoFrm));
                                    break;
                                case EClasificacion.Viento:
                                    guardadoBsd = Task.Run(() => adoTrompeta.AgregarTrompeta((Trompeta)frmSeleccion.instrumentoFrm));
                                    break;
                            }

                            MessageBox.Show("Agregado!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show("No se agrego al stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
            Task miTask;
            if (this.miLocal.Stock.Count > 0 && frmVenta.ShowDialog() == DialogResult.OK && frmVenta.InstrumentoFrmVenta is not null)
            {
                switch (frmVenta.InstrumentoFrmVenta.TipoInstrumento)
                {
                    case EClasificacion.Cuerda:
                        miTask = Task.Run(() => this.adoGuitarra.BorrarGuitarra((Guitarra)frmVenta.InstrumentoFrmVenta));
                        break;
                    case EClasificacion.Percusion:
                        miTask = Task.Run(() => this.adoBateria.BorrarBateria((Bateria)frmVenta.InstrumentoFrmVenta));
                        break;
                    default:
                        miTask = Task.Run(() => this.adoTrompeta.BorrarTrompeta((Trompeta)frmVenta.InstrumentoFrmVenta));
                        break;
                }
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
            if (this.miLocal.Ganancias > 0)
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
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("No hay ganancias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if (frmEstadistica.ShowDialog() == DialogResult.OK)
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
                    MessageBox.Show("Hubo un error al calcular las estadisticas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    ;
                default:
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
                            if (miArchivoTexto.Guardar<string>(this.rchTxtInformacion.Text, this.saveFileDialog.FileName))
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
                                MessageBox.Show("Hubo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        private void btnModificarStock_Click(object sender, EventArgs e)
        {
            Instrumento instrumentoAuxiliar;
            Task task;

            if (this.frmMuestraYseleccion.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (this.frmMuestraYseleccion.Clasificacion)
                    {
                        case EClasificacion.Cuerda:
                            if ((instrumentoAuxiliar = this.adoGuitarra.ObtenerGuitarra(this.frmMuestraYseleccion.Codigo)) is not null && frmGuitarra.ShowDialog() == DialogResult.OK)
                            {
                                instrumentoAuxiliar = frmGuitarra.InstrumentoFrm;
                                instrumentoAuxiliar.Codigo = this.frmMuestraYseleccion.Codigo;
                                task = Task.Run(() => this.adoGuitarra.ModificarGuitarra((Guitarra)instrumentoAuxiliar));
                                MessageBox.Show("Guitarra modificada");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al seleccionar ese instrumento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case EClasificacion.Percusion:
                            if ((instrumentoAuxiliar = this.adoBateria.ObtenerBateria(this.frmMuestraYseleccion.Codigo)) is not null && frmBateria.ShowDialog() == DialogResult.OK)
                            {
                                instrumentoAuxiliar = frmBateria.InstrumentoFrm;
                                instrumentoAuxiliar.Codigo = this.frmMuestraYseleccion.Codigo;
                                task = Task.Run(() => this.adoBateria.ModificarBateria((Bateria)instrumentoAuxiliar));
                                MessageBox.Show("Bateria modificada");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al seleccionar ese instrumento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case EClasificacion.Viento:
                            if ((instrumentoAuxiliar = this.adoTrompeta.ObtenerTrompeta(this.frmMuestraYseleccion.Codigo)) is not null && frmTrompeta.ShowDialog() == DialogResult.OK)
                            {
                                instrumentoAuxiliar = frmTrompeta.InstrumentoFrm;
                                instrumentoAuxiliar.Codigo = this.frmMuestraYseleccion.Codigo;
                                task = Task.Run(() => this.adoTrompeta.ModificarTrompeta((Trompeta)instrumentoAuxiliar));
                                MessageBox.Show("Trompeta modificada");
                            }
                            else
                            {
                                MessageBox.Show("Hubo un error al seleccionar ese instrumento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Instrumento instrumentoAuxiliar;
            Task miTask;
            if (this.frmMuestraYseleccion.ShowDialog() == DialogResult.OK)
            {
                switch (this.frmMuestraYseleccion.Clasificacion)
                {
                    case EClasificacion.Cuerda:
                        instrumentoAuxiliar = this.adoGuitarra.ObtenerGuitarra(this.frmMuestraYseleccion.Codigo);
                        if (instrumentoAuxiliar is not null)
                        {
                            miTask = Task.Run(() => this.adoGuitarra.BorrarGuitarra((Guitarra)instrumentoAuxiliar));
                            if (this.miLocal.Stock.Remove(instrumentoAuxiliar))
                            {
                                MessageBox.Show("Eliminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al seleccionar ese instrumento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case EClasificacion.Percusion:
                        instrumentoAuxiliar = this.adoBateria.ObtenerBateria(this.frmMuestraYseleccion.Codigo);
                        if (instrumentoAuxiliar is not null)
                        {
                            miTask = Task.Run(() => this.adoBateria.BorrarBateria((Bateria)instrumentoAuxiliar));
                            if (this.miLocal.Stock.Remove(instrumentoAuxiliar))
                            {
                                MessageBox.Show("Eliminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al seleccionar ese instrumento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case EClasificacion.Viento:
                        instrumentoAuxiliar = this.adoTrompeta.ObtenerTrompeta(this.frmMuestraYseleccion.Codigo);
                        if (instrumentoAuxiliar is not null)
                        {
                            miTask = Task.Run(() => this.adoTrompeta.BorrarTrompeta((Trompeta)instrumentoAuxiliar));
                            if (this.miLocal.Stock.Remove(instrumentoAuxiliar))
                            {
                                MessageBox.Show("Eliminado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hubo un error al seleccionar ese instrumento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    default:
                        break;
                }

            }
        }

    }
}
