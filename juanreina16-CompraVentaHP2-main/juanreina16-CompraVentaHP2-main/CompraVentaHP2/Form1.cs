namespace CompraVentaHP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            Form2 condicion1 = new Form2();
            condicion1.Show();
        }

        private void btnusu_Click(object sender, EventArgs e)
        {
            Form3 condicion1 = new Form3();
            condicion1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}