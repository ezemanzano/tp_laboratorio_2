using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
     public class Suv : Automoviles

    {
        protected override int Ruedas
        {
            get
            {
                if (Cilindrada >= 1800)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
        /// <summary>
        /// Constructor de un SUV
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="color"></param>
        /// <param name="cilindrada"></param>
        /// <param name="tipoAutomovil"></param>
        /// <param name="tipoModelo"></param>
        /// <param name="motor"></param>
        public Suv(string modelo, string color, int cilindrada, Tipo tipoAutomovil, TipoModelo tipoModelo, Motor motor) : base(modelo, color, cilindrada, tipoAutomovil, tipoModelo, motor)
        {
            
        }
    }
}
