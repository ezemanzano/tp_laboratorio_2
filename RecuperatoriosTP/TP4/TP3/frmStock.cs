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
    public partial class frmAgregarStock : Form
    {
        private int newStock;
        private Fabrica fabric;
        public frmAgregarStock(Fabrica fab)
        {
            InitializeComponent();
            this.fabric = fab;
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                newStock = (int)nudCantidad.Value;
                if (rbNaft.Checked == true)
                {                    
                    fabric.StockNafta += newStock;
                } else if (rbDie.Checked == true)
                {
                    fabric.StockDiesel += newStock;
                }
                else
                {
                    fabric.StockElectrico += newStock;
                }
            } else
            {
                MessageBox.Show("Complete todos los campos");
            }
            this.Close();
        }

        private bool Validar()
        {
            if (rbNaft.Checked == true || rbDie.Checked == true || rbElectric.Checked == true)
            {
                return true;
            }
            return false;
        }
    }
}
