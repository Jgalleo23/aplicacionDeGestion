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
    public partial class formAlta : Form
    {
        public formAlta()
        {
            InitializeComponent();
            formClientes clientes = new formClientes();

        }

        private void btOK_Click(object sender, EventArgs e)
        {

        }

        private void comboLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboLocalidad.SelectedItem.Equals("Almeria"))
            {
                txtCP.Text = "04001";
                txtPais.Text = "España";
            }
            if (comboLocalidad.SelectedItem.Equals("Cadiz"))
            {
                txtCP.Text = "11002";
                txtPais.Text = "España";
            }
            if (comboLocalidad.SelectedItem.Equals("Cordoba"))
            {
                txtCP.Text = "14003";
                txtPais.Text = "España";
            }
            if (comboLocalidad.SelectedItem.Equals("Granada"))
            {
                txtCP.Text = "18001";
                txtPais.Text = "España";
            }
            if (comboLocalidad.SelectedItem.Equals("Huelva"))
            {
                txtCP.Text = "21005";
                txtPais.Text = "España";
            }
            if (comboLocalidad.SelectedItem.Equals("Jaen"))
            {
                txtCP.Text = "23001";
                txtPais.Text = "España";
            }
            if (comboLocalidad.SelectedItem.Equals("Malaga"))
            {
                txtCP.Text = "29001";
                txtPais.Text = "España";
            }
            if (comboLocalidad.SelectedItem.Equals("Sevilla"))
            {
                txtCP.Text = "41001";
                txtPais.Text = "España";
            }
        }
    }
}
