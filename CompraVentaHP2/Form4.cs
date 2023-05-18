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
    public partial class Form4 : Form
    {
        int[,] CanMod;
        string[] Nombres;
        double[] ventasTotales, ganancia;
        int N = 2, f, C = 0;
        string N1, N2, N3, N4;


        int C2 = 0;


        public Form4()
        {
            InitializeComponent();
        }


        private void fff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnf1_Click(object sender, EventArgs e)
        {

            for (f = 0; f < N; f++)
            {
                lbf1.Text = "Nombre: " + Nombres[f] + "\n" + "Apellido: " + "\n" + "Documento: " + "\n" + "Telefono: " + "\n" + "Tipo de vehículo" + "\n" + "Ferrari: " + CanMod[f, 0] + "\n" + "Lamborghini: " + CanMod[f, 1] + "\n" + "Volkswagen: " + CanMod[f, 2] + "\n" + "Twingo: " + CanMod[f, 3] + "\n" + "\n" + "Ganancia: " + ganancia[f];
            }
        }

        private void btnf2_Click(object sender, EventArgs e)
        {
            for (f = 0; f < N; f++)
            {
                lbf1.Text = "Nombre: " + Nombres[f] + "\n" + "Apellido: " + "\n" + "Documento: " + "\n" + "Telefono: " + "\n" + "Tipo de vehículo" + "\n" + "Ferrari: " + CanMod[f, 0] + "\n" + "Lamborghini: " + CanMod[f, 1] + "\n" + "Volkswagen: " + CanMod[f, 2] + "\n" + "Twingo: " + CanMod[f, 3] + "\n" + "\n" + "Ganancia: " + ganancia[f];
            }
        }
        private void btnf3_Click(object sender, EventArgs e)
        {
            for (f = 0; f < N; f++)
            {
                lbf1.Text = "Nombre: " + Nombres[f] + "\n" + "Apellido: " + "\n" + "Documento: " + "\n" + "Telefono: " + "\n" + "Tipo de vehículo" + "\n" + "Ferrari: " + CanMod[f, 0] + "\n" + "Lamborghini: " + CanMod[f, 1] + "\n" + "Volkswagen: " + CanMod[f, 2] + "\n" + "Twingo: " + CanMod[f, 3] + "\n" + "\n" + "Ganancia: " + ganancia[f];
            }
        }

        private void btnf4_Click(object sender, EventArgs e)
        {
            for (f = 0; f < N; f++)
            {
                lbf1.Text = "Nombre: " + Nombres[f] + "\n" + "Apellido: " + "\n" + "Documento: " + "\n" + "Telefono: " + "\n" + "Tipo de vehículo" + "\n" + "Ferrari: " + CanMod[f, 0] + "\n" + "Lamborghini: " + CanMod[f, 1] + "\n" + "Volkswagen: " + CanMod[f, 2] + "\n" + "Twingo: " + CanMod[f, 3] + "\n" + "\n" + "Ganancia: " + ganancia[f];
            }
        }

        private void btnf5_Click(object sender, EventArgs e)
        {
            for (f = 0; f < N; f++)
            {
                lbf1.Text = "Nombre: " + Nombres[f] + "\n" + "Apellido: " + "\n" + "Documento: " + "\n" + "Telefono: " + "\n" + "Tipo de vehículo" + "\n" + "Ferrari: " + CanMod[f, 0] + "\n" + "Lamborghini: " + CanMod[f, 1] + "\n" + "Volkswagen: " + CanMod[f, 2] + "\n" + "Twingo: " + CanMod[f, 3] + "\n" + "\n" + "Ganancia: " + ganancia[f];
            }
        }

        private void btnf6_Click(object sender, EventArgs e)
        {
            for (f = 0; f < N; f++)
            {
                lbf1.Text = "Nombre: " + Nombres[f] + "\n" + "Apellido: " + "\n" + "Documento: " + "\n" + "Telefono: " + "\n" + "Tipo de vehículo" + "\n" + "Ferrari: " + CanMod[f, 0] + "\n" + "Lamborghini: " + CanMod[f, 1] + "\n" + "Volkswagen: " + CanMod[f, 2] + "\n" + "Twingo: " + CanMod[f, 3] + "\n" + "\n" + "Ganancia: " + ganancia[f];
            }
        }

    }
}
