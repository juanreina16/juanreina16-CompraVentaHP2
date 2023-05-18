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
    public partial class Form3 : Form
    {
        int[,] CanMod;
        string[] Nombres;
        double[] ventasTotales, ganancia;
        int N = 2, f, C = 0;
        string N1, N2, N3, N4;
        int C2 = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btncomprar_Click(object sender, EventArgs e)
        {
            txtferrari.Text = txtferrari.Text;
             lbimpresion.Text = "Nombre: " + Nombres[f] + "\n" + "Apellido: " + "\n" + "Documento: " + "\n" + "Telefono: " + "\n" + "Tipo de vehículo" + "\n" + "Ferrari: " + CanMod[f, 0] + "\n" + "Lamborghini: " + CanMod[f, 1] + "\n" + "Volkswagen: " + CanMod[f, 2] + "\n" + "Twingo: " + CanMod[f, 3] + "\n" + "\n" + "Ganancia: " + ganancia[f];
        }

        public void Calcular()
        {
            for (f = 0; f < N; f++)
            {

                ventasTotales[f] = Convert.ToDouble((CanMod[f, 0] * 70000000) + (CanMod[f, 1] * 60000000) + (CanMod[f, 2] * 74000000) + (CanMod[f, 3] * 80000000));

            }
            for (f = 0; f < N; f++)
            {

                ganancia[f] = 2000000 + (ventasTotales[f]);

            }
        }
    }
}
