using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
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
