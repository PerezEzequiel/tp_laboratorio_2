using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        #region Metodos

        /// <summary>
        /// Realiza determinada operacion(dependiendo el tipo de operador recibido) entre dos operandos.
        /// </summary>
        /// <param name="num1">Operando recibido.</param>
        /// <param name="num2">Operando recibido.</param>
        /// <param name="operador">Caracter recibido, este determinara que operacion se realizara.</param>
        /// <returns>Retorna el resultao de la operacion realizada.</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;
            char operadorAux = Calculadora.ValidarOperador(operador);
            
            switch(operadorAux)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida si el caracter recibido por parametros es un operador.
        /// </summary>
        /// <param name="operador">Caracter recibido.</param>
        /// <returns>Si el caracter recibido es un caracter, retorna ese mismo valor, caso contrario retorna el operador +.</returns>
        private static char ValidarOperador(char operador)
        {
            char aux;
            switch (operador)
            {
                case '-':
                    aux = operador;
                    break;
                case '*':
                    aux = operador;
                    break;
                case '/':
                    aux = operador;
                    break;
                default:
                    aux = '+';
                    break;
            }
            return aux;
        }

        #endregion

    }
}