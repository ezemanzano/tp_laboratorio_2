using System;
using Library;
namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabrica fabric = new Fabrica("Test Consola");
            bool agregar;

            Console.WriteLine($"Bienvenido a la fabrica de : {fabric.nombre}");
            fabric.StockNafta = 10;
            fabric.StockDiesel = 10;
            fabric.StockElectrico = 1;
            // Creo Automoviles Varios
            if (fabric.ConsumirMotor(1))
            {
                Auto car1 = new Auto("Clio", "Negro", 1200, Automoviles.Tipo.Auto, Automoviles.TipoModelo.Base, Automoviles.Motor.Nafta);
                agregar = fabric + car1;
                Console.WriteLine(car1.Informacion());
                ShowStock(fabric);
                Console.ReadKey();

            }
            if (fabric.ConsumirMotor(3))
            {
                Auto car2 = new Auto("Prius", "Azul", 1800, Automoviles.Tipo.Auto, Automoviles.TipoModelo.Full, Automoviles.Motor.Electrico);
                agregar = fabric + car2;
                Console.WriteLine(car2.Informacion());
                ShowStock(fabric);
                Console.ReadKey();
            }
            if (fabric.ConsumirMotor(1))
            {
                Moto moto1 = new Moto("Ninja", "Rojo", 2000, Automoviles.Tipo.Moto, Automoviles.TipoModelo.Full, Automoviles.Motor.Nafta);
                agregar = fabric + moto1;
                Console.WriteLine(moto1.Informacion());
                ShowStock(fabric);
                Console.ReadKey();
            }
            if (fabric.ConsumirMotor(2))
            {
                Moto moto2 = new Moto("RT", "Blanco", 2000, Automoviles.Tipo.Moto, Automoviles.TipoModelo.Full, Automoviles.Motor.Diesel);
                agregar = fabric + moto2;
                Console.WriteLine(moto2.Informacion());
                ShowStock(fabric);
                Console.ReadKey();
            }
            if (fabric.ConsumirMotor(2))
            {
                Suv suv1 = new Suv("HRV", "Negro", 1700, Automoviles.Tipo.Suv, Automoviles.TipoModelo.Base, Automoviles.Motor.Diesel);
                agregar = fabric + suv1;
                Console.WriteLine(suv1.Informacion());
                ShowStock(fabric);
                Console.ReadKey();
            }
            if (fabric.ConsumirMotor(3))
            {
                Suv suv2 = new Suv("3007", "Negro", 1900, Automoviles.Tipo.Suv, Automoviles.TipoModelo.Base, Automoviles.Motor.Electrico);
                agregar = fabric + suv2;
                Console.WriteLine(suv2.Informacion());
                ShowStock(fabric);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n No se pudo crear, no hay mas stock \n");
                Console.ReadKey();
            }
        
        }

        public static void ShowStock(Fabrica fab)
        {
            Console.WriteLine($"\nStock Nafta: {fab.StockNafta} \n");
            Console.WriteLine($"Stock Diesel: {fab.StockDiesel} \n");
            Console.WriteLine($"Stock Electrico: {fab.StockElectrico} \n");
        }
    }
}
