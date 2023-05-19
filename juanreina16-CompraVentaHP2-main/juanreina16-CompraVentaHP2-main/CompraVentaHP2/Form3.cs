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
            int n = dtgvproductos.Rows.Add();

            dtgvproductos.Rows[n].Cells[0].Value = txtnom.Text;
            dtgvproductos.Rows[n].Cells[1].Value = txtape.Text;
            dtgvproductos.Rows[n].Cells[2].Value = txtdoc.Text;
            dtgvproductos.Rows[n].Cells[3].Value = txtfono.Text;
            dtgvproductos.Rows[n].Cells[4].Value = txtferrari.Text;
            dtgvproductos.Rows[n].Cells[5].Value = txtlam.Text;
            dtgvproductos.Rows[n].Cells[6].Value = txtvol.Text;
            dtgvproductos.Rows[n].Cells[7].Value = txtgo.Text;

            txtnom.Text = "";
            txtape.Text = "";
            txtdoc.Text = "";
            txtfono.Text = "";
            txtferrari.Text = "";
            txtlam.Text = "";
            txtvol.Text = "";
            txtgo.Text = "";
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
