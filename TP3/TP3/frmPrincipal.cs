using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;


namespace TP3
{
    public partial class frmPrincipal : Form
    {
        private Fabrica fabrica;
        private frmAgregarStock addStock;
        public frmPrincipal()
        {
            InitializeComponent();
            this.fabrica = new Fabrica("Fabrica Eze Manzano");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableDescripcion(false);
            CargarForm();
            ActualizarStock();
        }

        /// <summary>
        /// Actualiza el stock de los motores
        /// </summary>
        private void ActualizarStock()
        {
            CargarStockNafta();
            CargarStockDiesel();
            CargarStockElectrico();

            lblStockNafta.Text = "Stock: " + $"{fabrica.StockNafta}";
            lblStockDiesel.Text = "Stock: " + $"{fabrica.StockDiesel}";
            lblStockElectrico.Text = "Stock: " + $"{fabrica.StockElectrico}";
        }

        /// <summary>
        /// Guarda los stocks de los motores
        /// </summary>
        private void GuardarStock()
        {
            GuardarStockNafta();
            GuardarStockElectrico();
            GuardarStockDiesel();
        }

        /// <summary>
        /// Carga la informacion al FORM
        /// </summary>
        public void CargarForm()
        {
            cmbTipo.Items.Add(Automoviles.Tipo.Auto);
            cmbTipo.Items.Add(Automoviles.Tipo.Suv);
            cmbTipo.Items.Add(Automoviles.Tipo.Moto);

            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;

            Serializadora<List<string>> colores = new Serializadora<List<string>>();
            List<string> colors = colores.Leer("Color.xml");
            foreach (string color in colors)
            { 
                lstboxColores.Items.Add(color);
            }

        }
        /// <summary>
        /// Guarda el informe de los automoviles creados.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        public void GuardarInfor(string nombreArchivo)
        {
            if (nombreArchivo == string.Empty)
            {
                nombreArchivo = "Informe de las " + DateTime.Now.Hour.ToString() + " Hs";
            }
           
            Serializadora<List<string>> cars = new Serializadora<List<string>>();
            List<string> test = new List<string>();
            foreach (Automoviles car in fabrica.produccion)
            {
                test.Add(car.Informacion());
            }
            cars.Guardar(nombreArchivo + ".xml", test);
        }

        /// <summary>
        /// Load del Stock leido desde un archivo XML
        /// </summary>

        public void CargarStockNafta()
        {
            Serializadora<int> stockNafta= new Serializadora<int>();
            int nafta = stockNafta.Leer("StockNafta.xml");
            fabrica.StockNafta = nafta;
        }
        /// <summary>
        /// Load del Stock leido desde un archivo XML
        /// </summary>
        public void CargarStockDiesel()
        {
            Serializadora<int> stockDiesel = new Serializadora<int>();
            int nafta = stockDiesel.Leer("StockDiesel.xml");
            fabrica.StockDiesel = nafta;
        }
        /// <summary>
        /// Load del Stock leido desde un archivo XML
        /// </summary>
        public void CargarStockElectrico()
        {
            Serializadora<int> stockElectrico = new Serializadora<int>();
            int electrico = stockElectrico.Leer("StockElectrico.xml");
            fabrica.StockElectrico = electrico;
        }

        /// <summary>
        /// Save del Stock a un archivo XML
        /// </summary>
        public void GuardarStockNafta()
        {
            Serializadora<int> stockNafta = new Serializadora<int>();
            int nafta = fabrica.StockNafta;
            stockNafta.Guardar("StockNafta.xml", nafta);
            
        }
        /// <summary>
        /// Save del Stock a un archivo XML
        /// </summary>
        public void GuardarStockDiesel()
        {
            Serializadora<int> stockDiesel = new Serializadora<int>();
            int diesel = fabrica.StockDiesel;
            stockDiesel.Guardar("StockDiesel.xml", diesel);
        }
        /// <summary>
        /// Save del Stock a un archivo XML
        /// </summary>
        public void GuardarStockElectrico()
        {
            try
            {
            Serializadora<int> stockElectrico = new Serializadora<int>();
            int electrico = fabrica.StockElectrico;
            stockElectrico.Guardar("StockElectrico.xml", electrico);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema al guardar stock");
            }
        }

        /// <summary>
        /// Habilita o deshabilita el numeric up down que corresponde a las peurtas.
        /// </summary>
        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Auto")
            {
                nudPuertas.Enabled = true;
            }
            else
            {
                nudPuertas.Enabled = false;                
            }
        }

       /// <summary>
       /// Devuelve el Tipo de Modelo leido desde el formulario
       /// </summary>
       /// <returns></returns>

        private Automoviles.TipoModelo GetTipoModelo()
        {
            

            if (rbBase.Checked == true)
            {
               return Automoviles.TipoModelo.Base;
            }
            else
            {
                return Automoviles.TipoModelo.Base;
            }
        }

        /// <summary>
        /// Devuelve el motor leido desde el formulario
        /// </summary>
        /// <returns></returns>

        private Automoviles.Motor GetMotor()
        {           
            if (rbNafta.Checked == true)
            {
                
                return Automoviles.Motor.Nafta;
            }
            else if (rbDiesel.Checked == true )
            {
               
               return Automoviles.Motor.Diesel;
            }
            else 
            {
         
                return Automoviles.Motor.Electrico;
            }            
        }

        /// <summary>
        /// Valida que no queden campos incompletos.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
            if (txtModelo.Text != string.Empty && (rbNafta.Checked == true || rbDiesel.Checked == true || rbElectrico.Checked == true) && cmbTipo.SelectedItem != null && lstboxColores.SelectedItem!=null && (rbBase.Checked == true || rbFull.Checked == true) )
            {
                return true;
            }
            
            return false;
        }

        /// <summary>
        /// Valida que tipo motor se selecciono y consume el stock del mismo
        /// </summary>
        /// <param name="fabric"></param>
        /// <returns></returns>

        private bool ValidarStockMotor(Fabrica fabric)
        {
            if (rbNafta.Checked == true && fabric.ConsumirMotor(1))
            {                
                return true;
            } else if (rbDiesel.Checked == true && fabric.ConsumirMotor(2))
            {
                return true;
            } else if (rbElectrico.Checked == true && fabric.ConsumirMotor(3))
            {                
                return true;
            } else
            {
            return false;
            }            
        }



        /// <summary>
        /// Devuelve el Tipo leido desde el formulario
        /// </summary>
        /// <returns></returns>
        private Automoviles.Tipo GetTipo()
        {
           

            if (cmbTipo.Text == "Auto")
            {
               return Automoviles.Tipo.Auto;
            }
            else if (cmbTipo.Text == "Suv")
            {
                return Automoviles.Tipo.Suv;
            }
            else
            {
                return Automoviles.Tipo.Moto;
            }
        }
        /// <summary>
        /// Devuelve la cantidad de puertas ingresads
        /// </summary>
        /// <returns></returns>
        private int GetCantidadPuertas()
        {
            return (int)nudPuertas.Value;
        }
        /// <summary>
        /// Devuelve color ingresado
        /// </summary>
        /// <returns></returns>
        private string GetColor()
        {
            return lstboxColores.SelectedItem.ToString(); 
        }

       /// <summary>
       /// Valida que la cilindrada ingresada sea correspondiente al tipo de automovil
       /// </summary>
       /// <returns></returns>

        private bool ValidarCilidrada()
        {
           if (cmbTipo.SelectedItem.ToString() == "Suv" && nudCilindrada.Value >= 1600)
            {
                return true;
            }else if (cmbTipo.SelectedItem.ToString() == "Moto" && nudCilindrada.Value == 2000)
            {
                return true;
            }
            else if (cmbTipo.SelectedItem.ToString() == "Auto" )
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Agrega un Automovil a la FAbrica
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {          
        
            Automoviles nuevoAutomovil;

            Automoviles.Tipo tipo;
            Automoviles.Motor motor;
            Automoviles.TipoModelo modelo;
            string color;
            int puertas;

            
            if (ValidarCampos()) 
            {            
                if (ValidarCilidrada())
                {
                    if (ValidarStockMotor(fabrica))
                    {
                        motor = GetMotor();
                        tipo = GetTipo();
                        modelo = GetTipoModelo();
                        color = GetColor();
                        puertas = GetCantidadPuertas();
                        if (tipo.ToString() == "Auto")
                        {
                            nuevoAutomovil = new Auto(txtModelo.Text, color, (int)nudCilindrada.Value, tipo, modelo, motor, puertas);

                        }
                        else if (tipo.ToString() == "Suv")
                        {
                            nuevoAutomovil = new Suv(txtModelo.Text, color, (int)nudCilindrada.Value, tipo, modelo, motor);
                        }
                        else
                        {
                            nuevoAutomovil = new Moto(txtModelo.Text, color, (int)nudCilindrada.Value, tipo, modelo, motor);
                        }

                        bool agregar;
                        agregar = this.fabrica + (Automoviles)nuevoAutomovil;

                        if (agregar == true)
                        {
                            lstbAutomoviles.Items.Add(nuevoAutomovil);
                            MessageBox.Show(nuevoAutomovil.Informacion());
                        }

                        GuardarStock();
                        ActualizarStock();
                        EnableDescripcion(true);
                    }
                    else
                    {
                        MessageBox.Show("No hay mas stock");
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Seleccionar la cilindrada correspondiente. \n Suv > 1600 - Moto = 2000");

                }
                                       
            
            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar");
                
                
            }

            

        }

        /// <summary>
        /// Habilita o deshabilita las opciones despues de crear un automovil.
        /// </summary>
        /// <param name="t"></param>
        private void EnableDescripcion(bool t)
        {
            btnDescripcion.Enabled = t;
            btnInforme.Enabled = t;
            lblInforme.Enabled = t;
            txtNombreInforme.Enabled = t;
        }

        /// <summary>
        /// Muestra la descripcion de un automovil seleccionado del listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDescripcion_Click(object sender, EventArgs e)
        {
            if (lstbAutomoviles.SelectedItem!=null)
            {
                Automoviles aux = (Automoviles)lstbAutomoviles.SelectedItem;
                MessageBox.Show(aux.Informacion());
            }
        }
        /// <summary>
        /// Guarda un informe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInforme_Click(object sender, EventArgs e)
        {
            GuardarInfor(txtNombreInforme.Text);
        }

       
        /// <summary>
        /// Llama a un formulario para agregar stock 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            addStock= new frmAgregarStock(fabrica);
            addStock.Location = this.Location;
            addStock.ShowDialog();
            GuardarStock();
            ActualizarStock();
        }
    }
}
