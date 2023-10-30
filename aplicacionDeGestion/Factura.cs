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
    public partial class formFactura : Form
    {
        public formFactura()
        {
            InitializeComponent();
            lbFechaActual.Text = DateTime.Now.ToString();
        }

        private void txtCodigoCliente_TextChanged(object sender, EventArgs e)
        {
            formClientes datosCliente = new formClientes();

            DataGridView dataGridView = datosCliente.datagridClientes;

            if (dataGridView.Rows[0].Cells["datagridCodigo"].Value.ToString() == txtCodigoCliente.Text)
            {
                // Obtener los datos de la primera fila
                DataGridViewRow firstRow = dataGridView.Rows[0];
                string dni = firstRow.Cells["datagridDNI"].Value.ToString();
                string nombre = firstRow.Cells["datagridNombre"].Value.ToString();
                string apellidos = firstRow.Cells["datagridApellidos"].Value.ToString();


                lbNombreCliente.Text = nombre;
                lbApellidosCliente.Text = apellidos;
                lbDNICliente.Text = dni;
                lbNombreCliente.Visible = true;
                lbApellidosCliente.Visible = true;
                lbDNICliente.Visible = true;


            }
            if (dataGridView.Rows[1].Cells["datagridCodigo"].Value.ToString() == txtCodigoCliente.Text)
            {
                // Obtener los datos de la segunda fila
                DataGridViewRow firstRow = dataGridView.Rows[1];
                string dni = firstRow.Cells["datagridDNI"].Value.ToString();
                string nombre = firstRow.Cells["datagridNombre"].Value.ToString();
                string apellidos = firstRow.Cells["datagridApellidos"].Value.ToString();


                lbNombreCliente.Text = nombre;
                lbApellidosCliente.Text = apellidos;
                lbDNICliente.Text = dni;
                lbNombreCliente.Visible = true;
                lbApellidosCliente.Visible = true;
                lbDNICliente.Visible = true;

            }
            if (dataGridView.Rows[2].Cells["datagridCodigo"].Value.ToString() == txtCodigoCliente.Text)
            {
                // Obtener los datos de la tercera fila
                DataGridViewRow firstRow = dataGridView.Rows[2];
                string dni = firstRow.Cells["datagridDNI"].Value.ToString();
                string nombre = firstRow.Cells["datagridNombre"].Value.ToString();
                string apellidos = firstRow.Cells["datagridApellidos"].Value.ToString();


                lbNombreCliente.Text = nombre;
                lbApellidosCliente.Text = apellidos;
                lbDNICliente.Text = dni;
                lbNombreCliente.Visible = true;
                lbApellidosCliente.Visible = true;
                lbDNICliente.Visible = true;

            }
            if (dataGridView.Rows[3].Cells["datagridCodigo"].Value.ToString() == txtCodigoCliente.Text)
            {
                // Obtener los datos de la cuarta fila
                DataGridViewRow firstRow = dataGridView.Rows[3];
                string dni = firstRow.Cells["datagridDNI"].Value.ToString();
                string nombre = firstRow.Cells["datagridNombre"].Value.ToString();
                string apellidos = firstRow.Cells["datagridApellidos"].Value.ToString();


                lbNombreCliente.Text = nombre;
                lbApellidosCliente.Text = apellidos;
                lbDNICliente.Text = dni;
                lbNombreCliente.Visible = true;
                lbApellidosCliente.Visible = true;
                lbDNICliente.Visible = true;

            }
            else
            {
                // No hay filas seleccionadas, mostrar un mensaje o tomar alguna otra acción apropiada
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Close();
        }

        private void btAñadirProducto_Click(object sender, EventArgs e)
        {
            formAgregarEnFactura agregarProducto = new formAgregarEnFactura();
            agregarProducto.ShowDialog();


            if (agregarProducto.DialogResult == DialogResult.OK)
            {
                var index = datagridProductos.Rows.Add();
                datagridProductos.Rows[index].Cells["datagridCodigoProducto"].Value = agregarProducto.txtNumCodigoProducto.Text;
                datagridProductos.Rows[index].Cells["datagridCodFact"].Value = txtCodigoFactura.Text;
                datagridProductos.Rows[index].Cells["datagridDescripcion"].Value = agregarProducto.rtxtDescripcion.Text;
                datagridProductos.Rows[index].Cells["datagridPrecio"].Value = agregarProducto.numericPrecio.Text;
                datagridProductos.Rows[index].Cells["datagridCantidad"].Value = agregarProducto.txtCantidad.Text;
                datagridProductos.Rows[index].Cells["datagridPrecioFinal"].Value = agregarProducto.numericPrecioFinal.Text;
            }
        }

        private void txtCodigoFactura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
