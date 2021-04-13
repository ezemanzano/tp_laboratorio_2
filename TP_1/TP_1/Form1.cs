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
        public FormCalculadora()
        {
            InitializeComponent();
        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnBinarioADecimal.Enabled = false;
            btnConvertirABinario.Enabled = false;
        }

        private void Limpiar()
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            cmbOperador.SelectedIndex = -1;
            lblResultado.Text = String.Empty;
            
        }
        
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

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {          
           string resul2;
           resul2 =  Numero.DecimalBinario(lblResultado.Text);
           lblResultado.Text = resul2;
           btnConvertirABinario.Enabled = false;

        }

        private void btnBinarioADecimal_Click(object sender, EventArgs e)
        {
            string resutaldo = lblResultado.Text;
            resutaldo = Numero.BinarioDecimal(resutaldo);
            lblResultado.Text = resutaldo;
            btnConvertirABinario.Enabled = true;


        }
    }
}
