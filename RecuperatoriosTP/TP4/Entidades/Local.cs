using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public delegate void errorAlCargarStock(object sender, EventArgs evento);
    public class Local<T> where T : Instrumento
    {
        private double ganancias;
        private double capital;
        private string nombreLocal;
        private string direccion;
        private int _capacidadMaxima;
        private List<T> _listaStock;
        private List<T> _listaVentas;
        private List<Empleado> _listaEmpleados;
        public event errorAlCargarStock eventoCargaError;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Local()
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="capacidad"></param>
        /// <param name="nombreLocal"></param>
        /// <param name="direccion"></param>
        /// <param name="capital"></param>
        public Local(int capacidad, string nombreLocal, string direccion, double capital)
        {
            this.CapacidadMaxima = capacidad;
            this.NombreLocal = nombreLocal;
            this.Direccion = direccion;
            this.Capital = capital;
            this.Stock = new List<T>();
            this.Empleados = new List<Empleado>();
            this.Ventas = new List<T>();

        }

        #region Propiedades 

        #region Porcentaje Stock

        /// <summary>
        /// Retorna el porcentaje de cuerdas que hay en el stock
        /// </summary>
        public double PorcentajeCuerdasStock
        {
            get
            {
                return Local<T>.CalcularPorcentaje(this._listaStock, EOrigen.Todos, EClasificacion.Cuerda);
            }
        }
        
        /// <summary>
        /// Retorna el porcentaje de vientos que hay en el stock
        /// </summary>
        public double PorcentajeVientosStock
        {
            get
            {
                return Local<T>.CalcularPorcentaje(this._listaStock, EOrigen.Todos, EClasificacion.Viento);
            }
        }


        /// <summary>
        /// Retorna el porcentaje de Percusion que hay en el stock
        /// </summary>
        public double PorcentajePercusionStock
        {
            get
            {
                return Local<T>.CalcularPorcentaje(this._listaStock, EOrigen.Todos, EClasificacion.Percusion);
            }
        }
        
        /// <summary>
        /// Retorna la informacion del stock.
        /// </summary>
        public string InformacionPorcentajeTotalStock
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Porcentaje  de stock cuerdas: %{this.PorcentajeCuerdasStock}");
                sb.AppendLine($"Porcentaje de stock vientos: %{this.PorcentajeVientosStock}");
                sb.AppendLine($"Porcentaje de stock Percusion: %{this.PorcentajeVientosStock}");
                return sb.ToString();
            }
        }
        #endregion

        #region Porcentaje Ventas
        /// <summary>
        /// Retorna el porcentaje de cuerdas que hay en las ventas
        /// </summary>
        public double PorcentajeCuerdasVentas
        {
            get
            {
                return Local<T>.CalcularPorcentaje(this._listaVentas, EOrigen.Todos, EClasificacion.Cuerda);
            }
        }


        /// <summary>
        /// Retorna el porcentaje de vientos que hay en las ventas
        /// </summary>
        public double PorcentajeVientosVentas
        {
            get
            {
                return Local<T>.CalcularPorcentaje(this._listaVentas, EOrigen.Todos, EClasificacion.Viento);
            }
        }

        /// <summary>
        /// Retorna el porcentaje de percusion que hay en las ventas
        /// </summary>
        public double PorcentajePercusionVentas
        {
            get
            {
                return Local<T>.CalcularPorcentaje(this._listaVentas, EOrigen.Todos, EClasificacion.Percusion);
            }
        }

        /// <summary>
        /// Retorna la informacion de las ventas
        /// </summary>
        public string PorcentajeTotalVentas
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Porcentaje ventas de cuerdas: % {this.PorcentajeCuerdasVentas}");
                sb.AppendLine($"Porcentaje ventas de vientos: % {this.PorcentajeVientosVentas}");
                sb.AppendLine($"Porcentaje ventas de Percusion: % {this.PorcentajePercusionVentas}");
                return sb.ToString();
            }
        }

        
        /// <summary>
        /// Calcula y retorna los porcentajes de ventas en cada pais.
        /// </summary>
        public string PorcentajeInstrumentosSegunPais
        {
            get
            {
                StringBuilder sb = new StringBuilder();


                foreach (EOrigen item in Enum.GetValues(typeof(EOrigen)))
                {
                    sb.Append($"{Local<T>.mostrarPorcentajeDeTodosLosInstrumentosPorPais(this._listaVentas, item)}");
                }

                return sb.ToString();
            }
        }

        #endregion

        /// <summary>
        /// Propiedad de lectura y escritura capacidad maxima
        /// </summary>
        public int CapacidadMaxima
        {
            set
            {
                if (value <= 0)
                {
                    throw new CampoInvalidoException("Capacidad maxima igual o menor a 0 no es valido.");
                }
                else
                {
                    this._capacidadMaxima = value;
                }
            }
            get
            {
                return this._capacidadMaxima;
            }
        }


        /// <summary>
        /// Propiedad de lectura y escritura capital
        /// </summary>
        public double Capital
        {
            get
            {
                return this.capital;
            }
            set
            {
                if(value<0 || value > double.MaxValue)
                {
                    throw new Exception("Capital invalido");
                }
                else
                {
                    this.capital = value;
                }
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura nombre local
        /// </summary>
        public string NombreLocal
        {
            set
            {
                if(value.Length<1)
                {
                    throw new CampoInvalidoException("Nombre muy corto");
                }
                else
                {
                    this.nombreLocal = value;
                }
            }
            get
            {
                return this.nombreLocal;
            }

        }


        /// <summary>
        /// Propiedad de lectura y escritura direccion
        /// </summary>
        public string Direccion
        {
            set
            {
                if(value.Length <= 0)
                {
                    throw new CampoInvalidoException("Direccion invalida");
                }
                else
                {
                    this.direccion = value;
                }
            }
            get
            {
                return this.direccion;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura ganancias
        /// </summary>
        public double Ganancias
        {
            set
            {
                this.ganancias = value;
            }
            get
            {
                return this.ganancias;
            }
        }
        
        /// <summary>
        /// Propiedad de lectura. Retorna la informacion del local.
        /// </summary>
        public string Informacion
        {
            get
            {
                return $"NombreLocal: {this.NombreLocal}\nDireccion: {this.Direccion}\nCapital: {this.Capital}\nCapacidadMax: {this.CapacidadMaxima}";
            }
        }

        /// <summary>
        /// Propiedad de lectura. Retorna la informacion promedio de sueldos de los empleados
        /// </summary>
        public string PromedioSalarioEmpleados
        {
            get
            {
                double rta = 0;
                if (this.Empleados.Count > 0)
                {
                    foreach (Empleado item in this.Empleados)
                    {
                        rta += item.Salario;
                    }
                    rta = rta / this.Empleados.Count;

                }

                return $"El promedio de los salarios de los empleados es $ {rta}";
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura ventas
        /// </summary>
        public List<T> Ventas
        {
            set
            {
                this._listaVentas = value;
            }
            get
            {
                return this._listaVentas;
            }
        }
        
        /// <summary>
        /// Propiedad de lectura y escritura stock
        /// </summary>
        public List<T> Stock
        {
            set
            {
                this._listaStock = value;
            }
            get
            {
                return this._listaStock;
            }
        }
        
        /// <summary>
        /// Propiedad de lectura y escritura empleados
        /// </summary>
        public List<Empleado> Empleados
        {
            set
            {
                this._listaEmpleados = value;
            }
            get
            {
                return this._listaEmpleados;
            }
        }
        
        #endregion


        /// <summary>
        /// Analiza si el empleado recibido por parametros se encuentra en la lista.
        /// </summary>
        /// <param name="local"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool operator ==(Local<T> local, Empleado e)
        {
            bool esta = false;
            foreach (Empleado item in local.Empleados)
            {
                if (item == e)
                {
                    esta = true;
                    break;
                }
            }
            return esta;
        }
        public static bool operator !=(Local<T> local, Empleado e)
        {
            return !(local == e);
        }


        /// <summary>
        /// Si tiene ganancias para pagar un empleado y si el mismo no esta en la lista, lo agrega.
        /// </summary>
        /// <param name="local"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool AgregarEmpleado(Local<T> local, Empleado e)
        {
            bool seAgrego = false;
            if (e.Salario > local.Ganancias)
            {
                throw new CampoInvalidoException("Exige un salario alto y no nos alcanza");
            }
            else
            {
                if (local != e)
                {
                    local.Empleados.Add(e);
                    local.Ganancias -= e.Salario;
                    seAgrego = true;
                }
            }

            return seAgrego;
        }


        /// <summary>
        /// Busca en la lista de stock, si existe un producto con el codigo recibido y lo retorna.
        /// </summary>
        /// <param name="local"></param>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static T operator |(Local<T> local, int codigo)
        {
            T miVariable = null;
            foreach (T item in local.Stock)
            {
                if (item.Codigo == codigo)
                {
                    miVariable = item;
                }
            }
            return miVariable;
        }

        /// <summary>
        /// Analiza si T ya se encuentra en la lista
        /// </summary>
        /// <param name="local"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Local<T> local, T a)
        {
            bool esta = false;
            foreach (T item in local.Stock)
            {
                if (item == a)
                {
                    esta = true;
                }

            }
            return esta;
        }
        public static bool operator !=(Local<T> local, T a)
        {
            return !(local == a);
        }


        /// <summary>
        /// Si lista de stock no supero su maximo, si no esta en la lista y si le alcanza su capital, lo compra y lo agrega.
        /// </summary>
        /// <param name="local"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator +(Local<T> local, T a)
        {
            bool seAgrego = false;
            if (local.Stock.Count < local.CapacidadMaxima && local != a && local.Capital >= a.Costo)
            {
                local.Stock.Add(a);
                local -= a.Costo;

                seAgrego = true;
            }
            else
            {
                local.eventoCargaError("No se pudo agregar este instrumento!!!",EventArgs.Empty);
            }
            return seAgrego;
        }

        /// <summary>
        /// Si, el producto se encuentra en el local, lo vende.
        /// </summary>
        /// <param name="local"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator -(Local<T> local, T a)
        {
            bool seVendio = false;
            if (local == a)
            {
                local += a.Costo;
                local.Ganancias += a.Precio - a.Costo;
                local.Stock.Remove(a);
                local.Ventas.Add(a);
                seVendio = true;
            }
            return seVendio;
        }

        /// <summary>
        /// Acumula en capital el parametro recibido.
        /// </summary>
        /// <param name="local"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Local<T> operator +(Local<T> local, double a)
        {
            local.Capital += a;
            return local;
        }

        /// <summary>
        /// Descuenta capital.
        /// </summary>
        /// <param name="local"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Local<T> operator -(Local<T> local, double a)
        {
            local.Capital -= a;
            return local;
        }
        
        /// <summary>
        /// Muesta de stock
        /// </summary>
        /// <param name="local"></param>
        /// <returns></returns>
        public static string MostrarStock(Local<T> local)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*******Lista de stock*******");
            foreach (T item in local.Stock)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        
        /// <summary>
        /// Muestra de empleados
        /// </summary>
        /// <param name="local"></param>
        /// <returns></returns>
        public static string MostrarEmpleados(Local<T> local)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*******Lista de Empleados*******");
            foreach (Empleado item in local.Empleados)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        
        /// <summary>
        /// Muestra de ventas
        /// </summary>
        /// <param name="local"></param>
        /// <returns></returns>
        public static string MostrarVentas(Local<T> local)
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in local.Ventas)
            {
                sb.AppendLine("*******Lista de ventas*******");
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Muestra las estadisticas de tipos de instrumentos de un pais
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="origen"></param>
        /// <returns></returns>
        private static string mostrarPorcentajeDeTodosLosInstrumentosPorPais(List<T> lista, EOrigen origen)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"-----------------{origen}-----------------");
            foreach (EClasificacion item in Enum.GetValues(typeof(EClasificacion)))
            {
                sb.AppendLine($"{item}: % {Local<T>.CalcularPorcentaje(lista, origen, item)}");
            }
            sb.AppendLine($"------------------------------------------");
            return sb.ToString();
        }

        /// <summary>
        /// Calcula el porcentaje de los tipos de instrumentos de un pais.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="origen"></param>
        /// <param name="clasificacion"></param>
        /// <returns></returns>
        private static double CalcularPorcentaje(List<T> lista, EOrigen origen, EClasificacion clasificacion)
        {
            int i = 0;
            int totalInstrumentosPais = Local<T>.CalcularTotalInstrumentosPorPais(lista, origen);
            double retorno = 0;

            if (totalInstrumentosPais != 0)
            {
                foreach (T item in lista)
                {
                    if (item.TipoInstrumento == clasificacion && (item.Origen == origen || origen == EOrigen.Todos))
                    {
                        i++;
                    }
                }
                retorno = (i * 100) / totalInstrumentosPais;
            }

            return retorno;
        }

        /// <summary>
        /// Calcula la cantidad de instrumentos que tiene un pais.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="origen"></param>
        /// <returns></returns>
        private static int CalcularTotalInstrumentosPorPais(List<T> lista, EOrigen origen)
        {
            int i = 0;
            foreach (T item in lista)
            {
                if (item.Origen == origen || origen == EOrigen.Todos)
                {
                    i++;
                }
            }
            return i;
        }
    }
}
