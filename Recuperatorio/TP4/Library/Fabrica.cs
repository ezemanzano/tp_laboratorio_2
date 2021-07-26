using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class Fabrica

    {

        protected int stockNafta;
        protected int stockDiesel;
        protected int stockElectrico;

        public int StockNafta
        {
            get 
            {
                return this.stockNafta;
            }
            set
            {
                this.stockNafta = value;
            }
        }

        public int StockDiesel
        {
            get
            {
                return this.stockDiesel;
            }
            set
            {
                this.stockDiesel= value;
            }
        }

        public int StockElectrico
        {
            get
            {
                return this.stockElectrico;
            }
            set
            {
                this.stockElectrico = value;
            }
        }



        public string nombre;
        public List<Automoviles> produccion;

        public List<Automoviles> Listas { get { return produccion; } }

        /// <summary>
        /// Contrsutcuto privado para incializar la lista de automoviles
        /// </summary>
        private Fabrica()
        {
            this.produccion = new List<Automoviles>();
            
        }

        /// <summary>
        /// Constructor de la fabrica.
        /// </summary>
        /// <param name="nombre"></param>
        public Fabrica(string nombre) : this()
        {
             this.nombre = nombre;
        }

        /// <summary>
        /// metodo para agregar automoviles a la lista de automoviles que contiene la farica
        /// </summary>
        /// <param name="f"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator +(Fabrica f, Automoviles a)
        {
            if (!(f is null) && !(a is null))
            {
                f.Listas.Add(a);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Metodo para reducir el stock de los motores de la fabrica a la hora de crear un nuevo automovil
        /// </summary>
        /// <param name="motor"></param>
        /// <returns></returns>

        public bool ConsumirMotor(int motor)
        {
            if (motor == 1 && this.StockNafta != 0)
            {
                this.StockNafta--;
                return true;
            }
            else if (motor == 2 && this.StockDiesel != 0)
            {
                this.StockDiesel--;
                return true;
            }
            else if (motor == 3 && this.StockElectrico != 0)
            {
                this.StockElectrico--;
                return true;
            }
            return false;
        }

      
    }
}
