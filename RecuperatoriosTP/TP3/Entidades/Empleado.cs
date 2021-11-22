using System;
using System.Text;

namespace Entidades
{
    public class Empleado
    {
        private int dni;
        private string nombre;
        private string apellido;
        private double salario;
        private ETipoEmpleado tipoEmpleado;
        private DateTime fechaIngreso;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Empleado()
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="DNI"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="salario"></param>
        /// <param name="tipo"></param>
        /// <param name="fechaIngreso"></param>
        public Empleado(int DNI, string nombre, string apellido, double salario, ETipoEmpleado tipo, DateTime fechaIngreso)
        {
            this.Dni = DNI;
            this.nombre = nombre;
            this.apellido = apellido;
            this.Salario = salario;
            this.tipoEmpleado = tipo;
            this.fechaIngreso = fechaIngreso;
        }


        /// <summary>
        /// Propiedad de lectura y escritura dni
        /// </summary>
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                if (value.ToString().Length != 8)
                {
                    throw new CampoInvalidoException("Dni invalido");
                }
                else
                {
                    this.dni = value;
                }
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura nombre
        /// </summary>
        public string Nombre
        {
            set
            {
                if (value.Length < 3)
                {
                    throw new CampoInvalidoException("Nombre muy corto");
                }
                else
                {
                    this.nombre = value;
                }

            }
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new CampoInvalidoException("Apellido muy corto");
                }
                else
                {
                    this.apellido = value;

                }
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura salario
        /// </summary>
        public double Salario
        {
            get
            {
                return this.salario;
            }
            set
            {
                if (value <= 0)
                {
                    throw new CampoInvalidoException("Ningun empleado trabaja gratis... salario invalido");
                }
                else
                {
                    this.salario = value;
                }
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura tipo empleado
        /// </summary>
        public ETipoEmpleado TipoEmpleado
        {
            set
            {
                this.tipoEmpleado = value;
            }
            get
            {
                return this.tipoEmpleado;
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura fecha de ingreso
        /// </summary>
        public DateTime FechaIngreso
        {
            set
            {
                this.fechaIngreso = value;
            }
            get
            {
                return this.fechaIngreso;
            }
        }

        /// <summary>
        /// Verifica igualdad entre dos empleados comparando su dni
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Empleado a, Empleado b)
        {
            return a.Dni == b.Dni;
        }
        public static bool operator !=(Empleado a, Empleado b)
        {
            return !(a == b);
        }


        /// <summary>
        /// Muestra de un empleado
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-------Empleado-------");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"DNI: {this.Dni}");
            sb.AppendLine($"Salario: {this.Salario}");
            sb.AppendLine($"Tipo Empleado: {this.TipoEmpleado}");
            sb.AppendLine($"Fecha ingreso: {this.FechaIngreso}");

            return sb.ToString();
        }
    }
}
