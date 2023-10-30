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
    public partial class formAgregarEnFactura : Form
    {
        public formAgregarEnFactura()
        {
            InitializeComponent();
        }

        private void txtNumCodigoProducto_TextChanged(object sender, EventArgs e)
        {
            formProductos datosProductos = new formProductos();

            DataGridView dataGridView = datosProductos.datagridProductos;

            if (dataGridView.Rows[0].Cells["datagridCodigoProducto"].Value.ToString() == txtNumCodigoProducto.Text)
            {

                DataGridViewRow firstRow = dataGridView.Rows[0];
                string descripcion = firstRow.Cells["datagridDescripcion"].Value.ToString();
                string precio = firstRow.Cells["datagridPrecio"].Value.ToString();
                string precioFinal = firstRow.Cells["datagridPrecioFinal"].Value.ToString();

                int precioCalculo = int.Parse(precio);
                int precioFinalCalculo = int.Parse(precioFinal);
                int cantidad = int.Parse(txtCantidad.Text);
                rtxtDescripcion.Text = descripcion;
                numericPrecio.Text = precio;
                precioFinalCalculo = cantidad * precioCalculo;
                numericPrecioFinal.Value = precioFinalCalculo;

            }
            else
            {
                // No hay filas seleccionadas, mostrar un mensaje o tomar alguna otra acción apropiada
            }

            if (dataGridView.Rows[1].Cells["datagridCodigoProducto"].Value.ToString() == txtNumCodigoProducto.Text)
            {

                DataGridViewRow firstRow = dataGridView.Rows[1];
                string descripcion = firstRow.Cells["datagridDescripcion"].Value.ToString();
                string precio = firstRow.Cells["datagridPrecio"].Value.ToString();
                string precioFinal = firstRow.Cells["datagridPrecioFinal"].Value.ToString();

                int precioCalculo = int.Parse(precio);
                int precioFinalCalculo = int.Parse(precioFinal);
                int cantidad = int.Parse(txtCantidad.Text);
                rtxtDescripcion.Text = descripcion;
                numericPrecio.Text = precio;
                precioFinalCalculo = cantidad * precioCalculo;
                numericPrecioFinal.Value = precioFinalCalculo;

            }
            else
            {
                // No hay filas seleccionadas, mostrar un mensaje o tomar alguna otra acción apropiada
            }

            if (dataGridView.Rows[2].Cells["datagridCodigoProducto"].Value.ToString() == txtNumCodigoProducto.Text)
            {

                DataGridViewRow firstRow = dataGridView.Rows[2];
                string descripcion = firstRow.Cells["datagridDescripcion"].Value.ToString();
                string precio = firstRow.Cells["datagridPrecio"].Value.ToString();
                string precioFinal = firstRow.Cells["datagridPrecioFinal"].Value.ToString();

                int precioCalculo = int.Parse(precio);
                int precioFinalCalculo = int.Parse(precioFinal);
                int cantidad = int.Parse(txtCantidad.Text);
                rtxtDescripcion.Text = descripcion;
                numericPrecio.Text = precio;
                precioFinalCalculo = cantidad * precioCalculo;
                numericPrecioFinal.Value = precioFinalCalculo;

            }
            else
            {
                // No hay filas seleccionadas, mostrar un mensaje o tomar alguna otra acción apropiada
            }

            if (dataGridView.Rows[3].Cells["datagridCodigoProducto"].Value.ToString() == txtNumCodigoProducto.Text)
            {

                DataGridViewRow firstRow = dataGridView.Rows[3];
                string descripcion = firstRow.Cells["datagridDescripcion"].Value.ToString();
                string precio = firstRow.Cells["datagridPrecio"].Value.ToString();
                string precioFinal = firstRow.Cells["datagridPrecioFinal"].Value.ToString();

                int precioCalculo = int.Parse(precio);
                int precioFinalCalculo = int.Parse(precioFinal);
                int cantidad = int.Parse(txtCantidad.Text);
                rtxtDescripcion.Text = descripcion;
                numericPrecio.Text = precio;
                precioFinalCalculo = cantidad * precioCalculo;
                numericPrecioFinal.Value = precioFinalCalculo;



            }
            else
            {
                // No hay filas seleccionadas, mostrar un mensaje o tomar alguna otra acción apropiada
            }
        }
    }
}
