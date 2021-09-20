using System;

namespace Entidades
{
    public class Operando
    {
        #region Campos
        public double numero;
        #endregion

        #region Constructores

        /// <summary>
        /// Crea un objeto de tipo Operando.
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Crea un objeto de tipo Operando inicianizandolo con el valor recibido.
        /// </summary>
        /// <param name="numero">Valor numerico a asignar.</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Crea un objeto de tipo Operando inicianizandolo con el valor recibido a traves de su propiedad set.
        /// </summary>
        /// <param name="strNumero">Valor numerico recibido como string.</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }


        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad Numero, su set escribe en el atributo numero, el valor recibido.
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }


        #endregion

        #region Metodos


        /// <summary>
        /// Valida si, el valor recibido por parametro se puede convertir a un dato tipo double.
        /// </summary>
        /// <param name="strNumero">Valor numerico recibido como string.</param>
        /// <returns>Retorna 0 si no se pudo hacer la conversion, de lo contrario retorna el valor recibido en un tipo de dato double.</returns>
        private double ValidarOperando(string strNumero)
        {
            double aux;
            if (!double.TryParse(strNumero, out aux))
            {
                aux = 0;
            }
            return aux;
        }

        
        /// <summary>
        /// Valida si, el parametro recibido es un valor de sistema numerico binario.
        /// </summary>
        /// <param name="binario">Valor recibido a analizar.</param>
        /// <returns>Retorna true si es un numero binario, de lo contrario, retorna false.</returns>
        public bool EsBinario(string binario)
        {
            bool aux = true;
            bool rta = false; 

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    aux = false;
                    break;
                }
            }
            if(aux == true && binario != "")
            {
                rta = true;
            }

            return rta;
        }
       
        
        
        /// <summary>
        /// Realiza la conversion de un valor binario a decimal.
        /// </summary>
        /// <param name="binario">Valor a convertir.</param>
        /// <returns>Si el valor recibido por parametros NO es un valor binario, retorna "Valor invalido", de lo contrario, retorna el valor recibido por parametros en decimal.</returns>
        public string BinarioDecimal(string binario)
        {
            string rta = "Valor invalido";
            double acumulador = 0;
            int largoCadena = binario.Length;

            if (this.EsBinario(binario))
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    largoCadena--;
                    if (binario[i] == '1')
                    {
                        acumulador = acumulador + Math.Pow(2, largoCadena);
                    }
                }
                rta = acumulador.ToString();
            }

            return rta;
        }



        /// <summary>
        /// Realiza la conversion de un valor decimal a binario.
        /// </summary>
        /// <param name="numero">Valor a convertir.</param>
        /// <returns>Retorna el valor recibido por parametros convertido en decimal.</returns>
        public string DecimalBinario(double numero)
        {
            int aux = (int)Math.Abs(numero);
            string rta = "";
            int resto = 0;

            if (aux >= 0)
            {
                do
                {
                    resto = aux % 2;
                    aux = aux / 2;
                    rta = resto.ToString() + rta;
                } while (aux > 0);
            }
            return rta;
        }


        /// <summary>
        /// Realiza la conversion de un valor decimal a binario.
        /// </summary>
        /// <param name="numero">Valor a convertir.</param>
        /// <returns>Si, el parametro NO es un string vacio, o es diferente de "Valor invalido", retorna el valor, de lo contrario retorna "Valor invalido".</returns>
        public string DecimalBinario(string numero)
        {
            string aux = "Valor invalido";
            if(numero!=aux && numero != "")
            {
                aux = this.DecimalBinario(Convert.ToDouble(numero));
            }
            return aux;
        }

        #endregion

        #region Sobrecargas


        /// <summary>
        /// Realiza la suma entre los parametros recibidos, accediendo al valor de su atributo numero.
        /// </summary>
        /// <param name="n1">Operando recibido.</param>
        /// <param name="n2">Operando recibido.</param>
        /// <returns>Retorna el resultado de la suma entre los operandos recibidos por parametro.</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Realiza la resta entre los parametros recibidos, accediendo al valor de su atributo numero.
        /// </summary>
        /// <param name="n1">Operando recibido.</param>
        /// <param name="n2">Operando recibido.</param>
        /// <returns>Retorna el resultado de la resta entre los operandos recibidos por parametro.</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Realiza la multiplicacion entre los parametros recibidos, accediendo al valor de su atributo numero.
        /// </summary>
        /// <param name="n1">Operando recibido.</param>
        /// <param name="n2">Operando recibido.</param>
        /// <returns>Retorna el resultado de la multiplicacion entre los operandos recibidos por parametro.</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Realiza si es posible, la division entre los parametros recibidos, accediendo al valor de su atributo numero.
        /// </summary>
        /// <param name="n1">Operando recibido.</param>
        /// <param name="n2">Operando recibido.</param>
        /// <returns>Si el segundo parametro recibido es igual a 0, retorna double.minValue, de lo contrario retorna el resultado de la division entre los dos operandos.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            double aux = double.MinValue;
            if (n2.numero != 0)
            {
                aux = n1.numero / n2.numero;
            }
            return aux;
        }

        #endregion
    }
}
