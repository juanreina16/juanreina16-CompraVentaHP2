using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompraVentaHP2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            MessageBox.Show("Tienes solo 3 intentos (la seguridad de nuestros usuarios es primero)");
        }
        int intentos = 0;


        private void btningresar_Click(object sender, EventArgs e)
        {
            Form4 condicion2 = new Form4();




            intentos++;
            if (txtusu.Text == "David69")
            {
                if (txtcontra.Text == "1122")
                {
                    txtcontra.Text = " ";
                    txtusu.Text = " ";
                    condicion2.Show();
                    Hide();
                }
                else
                {
                    txtcontra.Text = " ";
                    txtusu.Text = " ";
                    MessageBox.Show("El usuario o la contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                txtcontra.Text = " ";
                txtusu.Text = " ";
                MessageBox.Show("El usuario o la contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (string.IsNullOrEmpty(txtusu.Text) && string.IsNullOrEmpty(txtcontra.Text))
            {
                MessageBox.Show("Por favor, ingrese un usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (intentos == 3)
            {
                MessageBox.Show("Ha superado el límite de intentos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusu.Text = " ";
                txtcontra.Text = " ";
                this.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 condicion1 = new Form1();
            condicion1.Show();
            Hide();
        }
    }
}
