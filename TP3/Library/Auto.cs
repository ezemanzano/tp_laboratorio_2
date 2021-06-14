using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Auto : Automoviles , IInformacion
    {
        private int cantidadPuertas;

        protected override int Ruedas
        {
            get
            {
                return 4;
            }
        }

        public int CantidadPuertas 
        {
            get
            {
                return this.cantidadPuertas;
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

        public Auto(string modelo, string color, int cilindrada, Tipo tipoAutomovil, TipoModelo tipoModelo, Motor motor, int cantidadPuertas) : base(modelo,color,cilindrada,tipoAutomovil,tipoModelo,motor)
        {
            this.cantidadPuertas = cantidadPuertas;
        }


        /// <summary>
        /// Override de informacion para mostrar la cantidad de puertas.
        /// </summary>
        /// <returns></returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Informacion());
            sb.Append($"Cantidad de puertas: {CantidadPuertas}");
            return sb.ToString();
        }


    }
}
