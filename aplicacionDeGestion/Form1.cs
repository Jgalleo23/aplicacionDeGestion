namespace aplicacionDeGestion
{
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formClientes clientes = new formClientes();
            clientes.Show();
            this.Hide();
        }
    }
}