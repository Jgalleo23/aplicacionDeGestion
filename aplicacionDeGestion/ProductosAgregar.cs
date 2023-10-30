using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacionDeGestion
{
    public partial class formAgregarProducto : Form
    {
        public formAgregarProducto()
        {
            InitializeComponent();
            formProductos productos = new formProductos();
            txtNumCodigoProducto.Text = productos.codee.ToString();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            formProductos productos = new formProductos();
            txtNumCodigoProducto.Text = productos.codee.ToString();
            numericPrecioFinal.Value = ((numericPrecio.Value * numericBeneficio.Value) / 100) + numericPrecio.Value;
            Math.Round(numericPrecioFinal.Value, 2);
        }
    }
}
