using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        /// <summary>
        /// Resuelve una operación tras validar si el operador ingresado es correcto. 
        /// </summary>
        /// <param name="numero1">Objeto numero con el primer operando</param>
        /// <param name="numero2">Objeto numero con el segundo operando</param>
        /// <param name="operador">string con el operador</param>
        /// <returns>Devuelve el resultado de la operacion</returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;
            
            switch (ValidarOperador(Convert.ToChar(operador)))
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
                default:
                    resultado = numero1 + numero2;
                    break;
            }
            return resultado;

        }

        /// <summary>
        /// Valida si el operador ingresado es correcto, de no ser así utiliza el "+" como defecto
        /// </summary>
        /// <param name="operador"></param>
        /// <returns></returns>

        private static string ValidarOperador(char operador)
        {
            string resultado;            
            switch (operador)
            {
                case '+':
                    resultado = "+";
                    break;
                case '-':
                    resultado = "-";
                    break;
                case '*':
                    resultado = "*";
                    break;
                case '/':
                    resultado = "/";
                    break;
                default:
                    resultado = "+";
                    break;
            }
            return resultado;
        }

        
    }
}
