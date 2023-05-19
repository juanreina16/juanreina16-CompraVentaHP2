using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System;
using System.Collections.Generic;
using System.Linq;
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnImportar_Click(object sender, EventArgs e)
        {

        }
    }
   
    
}


