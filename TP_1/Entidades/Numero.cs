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

        public string SetNumero
        {
            set
            {            
                if (ValidarNumero(value) != 0)
                {
                    this.numero = double.Parse(value);
                }
            }
        }


        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = Convert.ToDouble(strNumero);
        }

        

        private double ValidarNumero(string strNumero)
        {
            double resultado;
            if (double.TryParse(strNumero, out resultado) == true)
            {
                return resultado;
            }
            return 0;
        }

        public static string BinarioDecimal(string binario)
        {
            double total = 0;
            if (EsBinario(binario))
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
       
        public static string DecimalBinario(string numero)
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
           
           
        

        private static bool EsBinario(string binario)
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


        public static double operator +(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero + n2.numero;
            return resultado;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero - n2.numero;
            return resultado;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            double resultado;
            resultado = n1.numero * n2.numero;
            return resultado;
        }

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
