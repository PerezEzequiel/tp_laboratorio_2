using System.Text;
using System.Xml.Serialization;

namespace Entidades
{

    [XmlInclude(typeof(Guitarra))]
    [XmlInclude(typeof(Bateria))]
    [XmlInclude(typeof(Trompeta))]
    public abstract class Instrumento
    {
        #region Campos
        private int porcentajeGanancia;
        private double costo;
        private int codigo;
        private string marca;
        private string modelo;
        private bool esUsado;
        private EOrigen origen;
        private EClasificacion tipoInstrumento;

        #endregion

        #region Constructor
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Instrumento()
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="costo"></param>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="esUsado"></param>
        /// <param name="porcentajeGanancia"></param>
        /// <param name="origen"></param>
        /// <param name="tipoInstrumento"></param>
        public Instrumento(double costo, int codigo, string marca, string modelo, bool esUsado, int porcentajeGanancia,EOrigen origen, EClasificacion tipoInstrumento)
        {
            this.Costo = costo;
            this.Codigo = codigo;
            this.marca = marca;
            this.modelo = modelo;
            this.esUsado = esUsado;
            this.origen = origen;
            this.tipoInstrumento = tipoInstrumento;
            this.PorcentajeGanancia = porcentajeGanancia;
            this.Precio=Instrumento.AplicarPorcentaje(this);
        }
        #endregion

        #region Propiedades
        /// <summary>
        ///  Propiedad de lectura y escritura de costo. 
        /// </summary>
        public double Costo
        {
            set
            {
                if(value<=0)
                { 
                    throw new CampoInvalidoException("Costo con numero igual menor a 0 no es valido.");
                }
                else
                {
                    this.costo = value;
                }
            }
            get
            {
                return this.costo;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de codigo
        /// </summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                if(value<=0)
                {
                    throw new CampoInvalidoException("Numero no valido");
                }
                else
                {
                    this.codigo = value;
                }
            } 
        }

        /// <summary>
        /// Propiedad de lectura y escritura de marca
        /// </summary>
        public string Marca
        {
            set
            {
                this.marca = value;
            }
            get
            {
                return this.marca;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de modelo
        /// </summary>
        public string Modelo
        {
            set
            {
                this.modelo = value;
            }
            get
            {
                return this.modelo;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de esUsado
        /// </summary>
        public bool EsUsado
        {
            set
            {
                this.esUsado = value;
            }
            get
            {
                return this.esUsado;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de origen
        /// </summary>
        public EOrigen Origen
        {
            set
            {
                this.origen = value;
            }
            get
            {
                return this.origen;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura de tipo instrumento
        /// </summary>
        public EClasificacion TipoInstrumento
        {
            set
            {
                this.tipoInstrumento = value;
            }
            get
            {
                return this.tipoInstrumento;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de porcentaje de ganancia.
        /// </summary>
        public int PorcentajeGanancia
        {
            set
            {
                if(value<=0)
                {
                    throw new CampoInvalidoException("Porcentaje ganancia con numero igual menor a 0 no es valido.");
                }
                else
                {
                    this.porcentajeGanancia = value;
                }
            }
            get
            {
                return this.porcentajeGanancia;
            }
        }
        /// <summary>
        /// Propiedad autoimplementada precio
        /// </summary>
        public double Precio
        {
            set;
            get;
        }

        #endregion

        #region Metodos 

        /// <summary>
        /// Aplica el porcentaje de ganancia al costo
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private static double AplicarPorcentaje(Instrumento a)
        {
            return  ((a.Costo * a.PorcentajeGanancia) / 100) + a.Costo;
        }
        /// <summary>
        /// Verifica la igualdad con sus codigos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Instrumento a, Instrumento b)
        {
            return a.Codigo == b.Codigo;
        }
        public static bool operator !=(Instrumento a, Instrumento b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Muestra de un instrumento.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo: {this.Codigo}");
            sb.AppendLine($"Marca: {this.Marca}");
            sb.AppendLine($"Modelo: {this.Modelo}");
            sb.AppendLine($"Origen: {this.Origen}");
            sb.AppendLine($"Usado: {this.EsUsado}");
            sb.Append($"Precio: {this.Precio}");

            return sb.ToString();
        }

        #endregion


    }
}
