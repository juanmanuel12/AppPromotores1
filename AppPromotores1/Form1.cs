namespace AppPromotores1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAltaProspectos_Click(object sender, EventArgs e)
        {
            AltaPromotores alta = new AltaPromotores();
            alta.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            FrmConsulta consul = new FrmConsulta();
            consul.ShowDialog();
        }
    }
}
