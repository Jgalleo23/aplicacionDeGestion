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
    public partial class formProductos : Form
    {
        public int codee = 4;
        public formProductos()
        {
            InitializeComponent();
            string[,] datos = new string[,]
            {
                {"1","Tornillo de Acero","4","10","4"},
                {"2","Tornillo de Papel","3","10","3"},
                {"3","Tornillo de Madera","1","10","1"},
                {"4","Tornillo de metal","2","10","2"}
            };
            for (int i = 0; i < datos.GetLength(0); i++)
            {
                datagridProductos.Rows.Add(new string[]
                    {
                    datos[i, 0],
                    datos[i, 1],
                    datos[i, 2],
                    datos[i, 3],
                    datos[i, 4]
                    });
            }

        }


        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            codee = codee + 1;
            formAgregarProducto agregarProducto = new formAgregarProducto();
            agregarProducto.ShowDialog();


            if (agregarProducto.DialogResult == DialogResult.OK)
            {
                var index = datagridProductos.Rows.Add();
                datagridProductos.Rows[index].Cells["datagridCodigoProducto"].Value = codee.ToString();
                datagridProductos.Rows[index].Cells["datagridDescripcion"].Value = agregarProducto.rtxtDescripcion.Text;
                datagridProductos.Rows[index].Cells["datagridPrecio"].Value = agregarProducto.numericPrecio.Text;
                datagridProductos.Rows[index].Cells["datagridBeneficio"].Value = agregarProducto.numericBeneficio.Text;
                datagridProductos.Rows[index].Cells["datagridPrecioFinal"].Value = agregarProducto.numericPrecioFinal.Text;
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Close();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEliminarProducto eliminarProducto = new formEliminarProducto();
            eliminarProducto.ShowDialog();

            int code = int.Parse(eliminarProducto.txtCodigoEliminar.Text);

            if (eliminarProducto.DialogResult == DialogResult.OK)
            {
                datagridProductos.Rows.RemoveAt(code);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEditarProductos editarProductos = new formEditarProductos();
            editarProductos.ShowDialog();


            if (editarProductos.DialogResult == DialogResult.OK)
            {
                var index = int.Parse(editarProductos.txtNumCodigoProducto.Text) - 1;
                datagridProductos.Rows[index].Cells["datagridCodigoProducto"].Value = editarProductos.txtNumCodigoProducto.Text;
                datagridProductos.Rows[index].Cells["datagridDescripcion"].Value = editarProductos.rtxtDescripcion.Text;
                datagridProductos.Rows[index].Cells["datagridPrecio"].Value = editarProductos.numericPrecio.Text;
                datagridProductos.Rows[index].Cells["datagridBeneficio"].Value = editarProductos.numericBeneficio.Text;
                datagridProductos.Rows[index].Cells["datagridPrecioFinal"].Value = editarProductos.numericPrecioFinal.Text;
            }
        }
    }
}
