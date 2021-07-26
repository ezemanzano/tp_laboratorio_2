using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Automoviles : IInformacion

    {
            public enum Tipo
            {
                Auto,
                Suv,
                Moto
            }

            public enum TipoModelo
            {
                Base,
                Full
            }

            public enum Motor
            {
                Nafta,
                Diesel,
                Electrico,
                Error
            }

      

            protected string modelo;
            protected string color;
            protected int cilindrada;
            protected Tipo tipoAutomovil;
            protected TipoModelo tipoModelo;
            protected Motor motor;
                
        
        protected abstract int Ruedas { get; }

        /// <summary>
        /// Constructor de un automovil
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="color"></param>
        /// <param name="cilindrada"></param>
        /// <param name="tipoAutomovil"></param>
        /// <param name="tipoModelo"></param>
        /// <param name="motor"></param>
        public Automoviles(string modelo,string color, int cilindrada, Tipo tipoAutomovil, TipoModelo tipoModelo, Motor motor) 
            {
                this.modelo = modelo;
                this.color = color;
                this.cilindrada = cilindrada;
                this.tipoAutomovil = tipoAutomovil;
                this.tipoModelo = tipoModelo;
                this.motor = motor;
            }


        /// <summary>
        /// Devuelve el modelo del autoautomovil
        /// </summary>
        public string GetModelo 
            {
                get
                    {
                        return this.modelo;
                    }
            }

        /// <summary>
        /// Devuelve el color del automovil
        /// </summary>
        public string GetColor
        {
            get
            {
                return this.color;
            }
        }

        /// <summary>
        /// Devuelve el tipo del automovil
        /// </summary>
        public Tipo GetTipo
        {
            get
            {
                return this.tipoAutomovil;
            }
        }
        /// <summary>
        /// Devuelve el motor del autoautomovil
        /// </summary>
        public Motor GetMotor
        {
            get
            {
                return this.motor;
            }
        }


        /// <summary>
        /// Devuelve el Tipo modelo del autoautomovil
        /// </summary>
        public TipoModelo GetTipoModelo
        {
            get
            {
                return this.tipoModelo;
            }
        }

        /// <summary>
        /// Devuelve la cilindrada del autoautomovil
        /// </summary>
        public int Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }

        /// <summary>
        /// Override del toString para modificar como se muestra la cilindrda
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string cilin = Cilindrada.ToString().Insert(1, ".");
            cilin = cilin.Remove(3,2);
            return GetModelo + " " + cilin;
        }
        /// <summary>
        /// Metodo virtual para mostrar la informacion del auto
        /// </summary>
        /// <returns></returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Modelo: {GetModelo}");
            sb.AppendLine($"Tipo: {GetTipo.ToString()}");
            sb.AppendLine($"Cilirdrada {Cilindrada}");
            sb.AppendLine($"Cantidad Ruedas: {Ruedas}");
            sb.AppendLine($"Tipo de modelo: {GetTipoModelo.ToString()}");
            sb.AppendLine($"Motor: {GetMotor.ToString()}");
            sb.AppendLine($"Color: {GetColor}");
            return sb.ToString();
        }


       

    }
}

