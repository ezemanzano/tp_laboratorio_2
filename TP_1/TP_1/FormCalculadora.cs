using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TP_1
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Inicia el form
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Resuelve la operación al clickear en el boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (cmbOperador.Text == "")
            {
                cmbOperador.Text = "+";
            }
            lblResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            btnBinarioADecimal.Enabled = true;
            btnConvertirABinario.Enabled = true;
            
        }

        /// <summary>
        /// Cierra la aplicación al presionar el boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Limpia los operandos, el operador, el resultado y deshabilita los conversores.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnBinarioADecimal.Enabled = false;
            btnConvertirABinario.Enabled = false;
        }

        /// <summary>
        /// Metodo para limpiar los campos de la calculadora
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = String.Empty;
            
        }
        /// <summary>
        /// Resuelve un calculo apartir de los parametros ingresadros
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Operador</param>
        /// <returns>Double con el resultado.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Numero num1 = new Numero();
            Numero num2 = new Numero();
            num1.SetNumero = numero1;
            num2.SetNumero = numero2;
            resultado = Calculadora.Operar(num1,num2,operador);
            return resultado;
        }
        /// <summary>
        /// Resuelve la conversion de Decimal a Binario, deshabilita el botón del mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
           Numero num1 = new Numero();
           string resul2;
           resul2 =  num1.DecimalBinario(lblResultado.Text);
           lblResultado.Text = resul2;
           btnConvertirABinario.Enabled = false;

        }
        /// <summary>
        /// Resuelve la conversion de  Binario a Decimal, deshabilita el botón del mismo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            Numero num1 = new Numero();
            string resutaldo = lblResultado.Text;
            resutaldo = num1.BinarioDecimal(resutaldo);
            lblResultado.Text = resutaldo;
            btnConvertirABinario.Enabled = true;
        }
    }
}
