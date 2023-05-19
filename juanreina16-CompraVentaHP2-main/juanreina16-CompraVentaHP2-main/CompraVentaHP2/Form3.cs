using DocumentFormat.OpenXml.Vml;
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
        int precio = 0;
        string pasarela = "";
        int conRad = 0;
        float total = 0;
        private int recargo;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
        }
        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProducto.Text;

            if (producto.Equals("Ferrari")) precio = 250;
            lblPrecio.Text = (0).ToString("c");
            if (producto.Equals("Lamborghini")) precio = 150;
            lblPrecio.Text = (0).ToString("c");
            if (producto.Equals("Volkswagen")) precio = 350;
            lblPrecio.Text = (0).ToString("c");
            if (producto.Equals("Twingo")) precio = 300;
            lblPrecio.Text = (0).ToString("c");


            if (rdAmerican.Checked == true)
            {
                pasarela = "Pago con American Express ";
                conRad++;
            }
            if (rdGana.Checked == true)
            {
                pasarela = "Pago con Bancolombia ";
                conRad++;
            }

            lblPrecio.Text = total.ToString("c");

            

        }
        private void btncomprar_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedIndex == -1)
                MessageBox.Show("Tienes que seleccionar el producto deseado");
            else if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar la cantidad");
            else if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Tienes que seleccionar un tipo");

            else
            {
                //aqui se empieza a captura los datos 


                string tipo = cboTipo.Text;

                int cantidad = Convert.ToInt32(txtCantidad.Text);
                //el  proceso del calculo


                if (conRad > 0 && cantidad > 0)
                {
                    total = precio * cantidad;
                    lblResultado.Text = pasarela + total.ToString("c"); ;

                }
                double subtotal = total;

                double descuento = 0; recargo = 0;
                if (tipo.Equals("contado"))
                    descuento = 0.05 * subtotal;

                else
                    recargo = (int)(0.1 * subtotal);

                double precioFinal = subtotal - descuento + recargo;


            }

            int n = dtgvproductos.Rows.Add();

            dtgvproductos.Rows[n].Cells[0].Value = txtnom.Text;
            dtgvproductos.Rows[n].Cells[1].Value = txtape.Text;
            dtgvproductos.Rows[n].Cells[2].Value = txtdoc.Text;
            dtgvproductos.Rows[n].Cells[3].Value = txtfono.Text;
            dtgvproductos.Rows[n].Cells[4].Value = cboProducto.Text;
            dtgvproductos.Rows[n].Cells[5].Value = txtCantidad.Text;
            dtgvproductos.Rows[n].Cells[6].Value = lblResultado.Text = (0).ToString("c");
            dtgvproductos.Rows[n].Cells[7].Value = pasarela;
            dtgvproductos.Rows[n].Cells[8].Value = cboProducto.Text;

            txtnom.Text = "";
            txtape.Text = "";
            txtdoc.Text = "";
            txtfono.Text = "";
            cboProducto.Text = "";
            txtCantidad.Text = "";
            lblResultado.Text = "";
            txtgo.Text = "";
            cboProducto.Text = "";
            rdAmerican.Checked = false;
            rdGana.Checked = false;
        }
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            exportaraexcel(dtgvproductos);
        }
        public void Calcular()
        {
            int ferrari = 70000000;
            int lambo = 8000000;
            int volks = 900000000;
            int twingo = 2000;

            for (f = 0; f < N; f++)
            {

                ventasTotales[f] = Convert.ToDouble((CanMod[f, 0] * ferrari) + (CanMod[f, 1] * lambo) + (CanMod[f, 2] * volks) + (CanMod[f, 3] * twingo));

            }
            for (f = 0; f < N; f++)
            {

                ganancia[f] = 2000000 + (ventasTotales[f]);

            }
        }

        private void btnvisualizar_Click(object sender, EventArgs e)
        {

            Form2 condicion1 = new Form2();
            condicion1.Show();
            Hide();
            MessageBox.Show("Primero debe ingresar como administrador");

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
