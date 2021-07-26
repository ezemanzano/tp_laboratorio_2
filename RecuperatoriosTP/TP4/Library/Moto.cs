using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class Moto : Automoviles
    {
        protected override int Ruedas
        {
            get
            {
                return 2;
            }
        }
        /// <summary>
        /// Constructor de la moto
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="color"></param>
        /// <param name="cilindrada"></param>
        /// <param name="tipoAutomovil"></param>
        /// <param name="tipoModelo"></param>
        /// <param name="motor"></param>
        public Moto(string modelo, string color, int cilindrada, Tipo tipoAutomovil, TipoModelo tipoModelo, Motor motor) : base(modelo, color, cilindrada, tipoAutomovil, tipoModelo, motor)
        {
           
        }
    }
}
