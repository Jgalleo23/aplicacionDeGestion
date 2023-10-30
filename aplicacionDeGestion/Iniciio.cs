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
            formMenu menu = new formMenu();
            menu.Show();
            this.Hide();
        }
    }
}