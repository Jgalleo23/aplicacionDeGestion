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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btProductosFormulario_Click(object sender, EventArgs e)
        {
            formProductos productos = new formProductos();
            productos.Show();
            this.Close();
        }

        private void btClientesFormulario_Click(object sender, EventArgs e)
        {
            formClientes clientes = new formClientes();
            clientes.Show();
            this.Close();
        }

        private void btFactura_Click(object sender, EventArgs e)
        {
            formFactura factura = new formFactura();
            factura.Show();
            this.Close();
        }
    }
}
