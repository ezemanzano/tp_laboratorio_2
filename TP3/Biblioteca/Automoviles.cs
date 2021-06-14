using System;

namespace Biblioteca
{
    public class Automoviles
    
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
            Electrico
        }

        protected string modelo;

        protected ConsoleColor color;

        protected int cilindrada;

        protected int cantidadPuertas;

        protected Tipo tipoAutomovil;

        protected TipoModelo tipoModelo;

        protected Motor motor;

        public Automoviles(string modelo, ConsoleColor color, int cilindrada, Tipo tipoAutomovil, TipoModelo tipoModelo, Motor motor)
        {
            this.modelo = modelo;
            this.color = color;
            this.cilindrada = cilindrada;
            this.tipoAutomovil = tipoAutomovil;
            this.tipoModelo = tipoModelo;
            this.motor = motor;
        }




    }
}
