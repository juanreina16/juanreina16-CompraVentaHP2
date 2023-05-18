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
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            Form4 condicion2 = new Form4();

            int intentos = 0;
            if (txtusu.Text == "David69")
            {

                
               
                if (txtcontra.Text == "1122")
                {
                    txtcontra.Text = " ";
                    txtusu.Text = " ";
                    condicion2.Show();
                }

                else
                {
                    txtcontra.Text = " ";
                    txtusu.Text = " ";
                    MessageBox.Show("El usuario o la contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    intentos++;
                }
            }

            else 
            {
                txtcontra.Text = " ";
                txtusu.Text = " ";
                MessageBox.Show("El usuario o la contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                intentos++;

            }

            if (intentos > 3)
            {
                
                MessageBox.Show("Ha superado el límite de intentos, por favor coma mierda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusu.Text = " ";
                txtcontra.Text = " ";
            }
            else
            {
               
            }
           

        }
    }
}
