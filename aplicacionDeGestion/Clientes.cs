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

    public partial class formClientes : Form
    {
        private object Codigoclientes()
        {
            String codigo = ((datagridClientes.Rows.Count) - 1).ToString();
            return codigo;
        }


        public formClientes()
        {
            InitializeComponent();
            datagridCP.Visible = false;
            datagridLocalidad.Visible = false;
            datagridPais.Visible = false;

            string[,] datos = new string[,]
            {
                {"1","José","Gallego","49106930L","21005","Malaga","Malaga","677712339" },
                {"2","Enrique","León","689123456P","21003","Sevilla","Sevilla","689134412" },
                {"3","Belén","Ortega","75918312R","21006","Dos Hermanas","Sevilla","748191771" },
                {"4","Pedro","Dominguez","789939581M","20009","Cadiz","Cadiz","88775889123"}
            };
            for (int i = 0; i < datos.GetLength(0); i++)
            {

                datagridClientes.Rows.Add(new string[]
                    {
                    datos[i, 0],
                    datos[i, 1],
                    datos[i, 2],
                    datos[i, 3],
                    datos[i, 4],
                    datos[i, 5],
                    datos[i, 6],
                    datos[i, 7],
                    });
            }
        }

        private void altaclienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAlta alta = new formAlta();
            alta.ShowDialog();

            if (alta.DialogResult == DialogResult.OK)
            {
                var index = datagridClientes.Rows.Add();
                datagridClientes.Rows[index].Cells["datagridCodigo"].Value = Codigoclientes();
                datagridClientes.Rows[index].Cells["datagridNombre"].Value = alta.txtNombre.Text;
                datagridClientes.Rows[index].Cells["datagridApellidos"].Value = alta.txtApellidos.Text;
                datagridClientes.Rows[index].Cells["datagridDNI"].Value = alta.txtDNI.Text;
                datagridClientes.Rows[index].Cells["datagridTelefono"].Value = alta.txtTelefono.Text;
                datagridClientes.Rows[index].Cells["datagridCP"].Value = alta.txtCP.Text;
                datagridClientes.Rows[index].Cells["datagridLocalidad"].Value = alta.comboLocalidad.Text;
                datagridClientes.Rows[index].Cells["datagridPais"].Value = alta.txtPais.Text;



            }
        }

        private void formClientes_Load(object sender, EventArgs e)
        {

        }

        private void bajaclienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBajas baja = new formBajas();
            baja.ShowDialog();

            int code = int.Parse(baja.txtCodigoBajas.Text);

            if (baja.DialogResult == DialogResult.OK)
            {
                datagridClientes.Rows.RemoveAt(code);
            }


        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            formMenu menu = new formMenu();
            menu.Show();
            this.Close();
        }

        private void modificacionesclienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formModificarCliente modificarClientes = new formModificarCliente();
            modificarClientes.ShowDialog();


            if (modificarClientes.DialogResult == DialogResult.OK)
            {
                var index = int.Parse(modificarClientes.txtNumCodigo.Text) - 1;
                
                datagridClientes.Rows[index].Cells["datagridCodigo"].Value = modificarClientes.txtNumCodigo.Text;
                datagridClientes.Rows[index].Cells["datagridNombre"].Value = modificarClientes.txtNombre.Text;
                datagridClientes.Rows[index].Cells["datagridApellidos"].Value = modificarClientes.txtApellidos.Text;
                datagridClientes.Rows[index].Cells["datagridDNI"].Value = modificarClientes.txtDNI.Text;
                datagridClientes.Rows[index].Cells["datagridTelefono"].Value = modificarClientes.txtTelefono.Text;
                datagridClientes.Rows[index].Cells["datagridCP"].Value = modificarClientes.txtCP.Text;
                datagridClientes.Rows[index].Cells["datagridLocalidad"].Value = modificarClientes.comboLocalidad.Text;
                datagridClientes.Rows[index].Cells["datagridPais"].Value = modificarClientes.txtPais.Text;
            }
        }
    }
}
