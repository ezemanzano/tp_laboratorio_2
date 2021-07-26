using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Auto : Automoviles , IInformacion
    {
        

        protected override int Ruedas
        {
            get
            {
                return 4;
            }
        }

     

        /// <summary>
        /// Constructor de un Auto
        /// </summary>
        /// <param name="modelo"> Modelo del auto</param>
        /// <param name="color"> Color del auto</param>
        /// <param name="cilindrada"> Cilindrada del auto</param>
        /// <param name="tipoAutomovil"> tipo de Auto</param>
        /// <param name="tipoModelo">Tipo del modelo</param>
        /// <param name="motor">TIpo de motor </param>
        /// <param name="cantidadPuertas"> Cantidad de puertas</param>

        public Auto(string modelo, string color, int cilindrada, Tipo tipoAutomovil, TipoModelo tipoModelo, Motor motor) : base(modelo,color,cilindrada,tipoAutomovil,tipoModelo,motor)
        {
           
        }


        /// <summary>
        /// Override de informacion para mostrar la cantidad de puertas.
        /// </summary>
        /// <returns></returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
           
            return sb.ToString();
        }


    }
}
