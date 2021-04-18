using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;


namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Propiedad para asignarle un valor a la variable numero validandolo.
        /// </summary>
        public string SetNumero
        {
            set
            {
               this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Numero()
        {
            this.numero = 0;
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="numero"> valor del atributo pasado por parametro</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="strNumero">Valor del atributo pasado por parametro como String</param>
        public Numero(string strNumero)
        {
            this.numero = double.Parse(strNumero);
        }

        
        /// <summary>
        /// Validar si lo ingresado por parametro es un numero
        /// </summary>
        /// <param name="strNumero">Parametro a validar</param>
        /// <returns>Devuelve el resultado de ser correcto | Si no pudo devuelve 0</returns>

        private double ValidarNumero(string strNumero)
        {
            double resultado;
            if (double.TryParse(strNumero, out resultado) == true)
            {
                return resultado;
            }
            return 0;
        }

        /// <summary>
        /// Conversor de Binario A Decimal
        /// </summary>
        /// <param name="binario">Ingreso del binario en formato String</param>
        /// <returns>String con la conversión de ser correcta | Error = "No es binario"</returns>
        public string BinarioDecimal(string binario)
        {
            Numero numb= new Numero();
            double total = 0;
            if (numb.EsBinario(binario))
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    if (binario[i] == '1')
                    {                        
                        total = total + (Math.Pow(2, (binario.Length - i - 1)));
                    }
                }
                return total.ToString();
            }
            return "No es Binario";

        }
       /// <summary>
       ///  Conversor de Decimal a Binario
       /// </summary>
       /// <param name="numero">Decimal a convertir en formato String</param>
       /// <returns>String con la conversión de ser correcta | Error = -1</returns>
        public string DecimalBinario(string numero)
        {
            double num;

            if (double.TryParse(numero, out num))
            {
                int aux = (int)Math.Abs(num);                
                string binario = String.Empty;
                do
                {
                    binario = Convert.ToString(aux % 2) + binario;
                    aux = aux / 2;
                } while (aux >= 1);
                return binario;
            }
            else
                return "-1";
            
        }
           
           
        
        /// <summary>
        /// Chequea si el string pasado por parametro es un Binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns></returns>
        private bool EsBinario(string binario)
        {
            for (int i = 0; i < binario.Length; i++)
            {
                if (!(binario[i] == '1' || binario[i] == '0'))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Operador de Suma
        /// </summary>
        /// <param name="n1">Objeto Numero -> Primer operando </param>
        /// <param name="n2">Objeto Numero -> Segundo operando </param>
        /// <returns>Devuelve el resultado de la suma</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero + n2.numero;
            return resultado;
        }
        /// <summary>
        /// Operador de Resta
        /// </summary>
        /// <param name="n1">Objeto Numero -> Primer operando </param>
        /// <param name="n2">Objeto Numero -> Segundo operando </param>
        /// <returns>Devuelve el resultado de la resta</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero - n2.numero;
            return resultado;
        }

        /// <summary>
        /// Operador de Multiplicación
        /// </summary>
        /// <param name="n1">Objeto Numero -> Primer operando </param>
        /// <param name="n2">Objeto Numero -> Segundo operando </param>
        /// <returns>Devuelve el resultado de la Multiplicacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero * n2.numero;
            return resultado;
        }
        /// <summary>
        /// Operador de Division, chequea si no se está dividiendo por 0
        /// </summary>
        /// <param name="n1">Objeto Numero -> Primer operando </param>
        /// <param name="n2">Objeto Numero -> Segundo operando </param>
        /// <returns>Devuelve el resultado de la division | si da error devuelve double.MinValue</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double resultado;
            if (n2.numero != 0)
            {
                resultado = n1.numero / n2.numero;               
            }
            else
            {
                resultado = double.MinValue;
            }               
            return resultado;
        }


    }
}
