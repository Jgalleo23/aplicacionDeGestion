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
        public formClientes()
        {
            InitializeComponent();
            datagridCP.Visible = false;
            datagridLocalidad.Visible = false;
            datagridPais.Visible = false;
        }

        private void altaclienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAlta alta = new formAlta();
            alta.ShowDialog();
            
            if (alta.DialogResult == DialogResult.OK)
            {
                var index = datagridClientes.Rows.Add();
                datagridClientes.Rows[index].Cells["datagridNombre"].Value = alta.txtNombre.Text;

            }
        }
    }
}
