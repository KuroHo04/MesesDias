using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesesDias
{
    public partial class LosMeses : Form
    {
        public LosMeses()
        {
            InitializeComponent();
        }

        private void btnEnero_Click(object sender, EventArgs e)
        {
            Meses mes1 = new Meses();
            mes1.Mes = "Enero";
            mes1.Dias = 31;

            MessageBox.Show(mes1.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meses mes2 = new Meses();
            mes2.Mes = "Febrero";
            mes2.Dias = 28;
            MessageBox.Show(mes2.ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Meses mes3 = new Meses();
            mes3.Mes = "Marzo";
            mes3.Dias = 31;

            MessageBox.Show(mes3.ToString());
        }

        private void btnAbril_Click(object sender, EventArgs e)
        {
            Meses mes4 = new Meses();
            mes4.Mes = "Abril";
            mes4.Dias = 30;

            MessageBox.Show(mes4.ToString());
        }

        private void btnMayo_Click(object sender, EventArgs e)
        {
            Meses mes5 = new Meses();
            mes5.Mes = "Mayo";
            mes5.Dias = 31;

            MessageBox.Show(mes5.ToString());
        }

        private void btnJunio_Click(object sender, EventArgs e)
        {
            Meses mes6 = new Meses();
            mes6.Mes = "Junio";
            mes6.Dias = 30;

            MessageBox.Show(mes6.ToString());
        }

        private void btnJulio_Click(object sender, EventArgs e)
        {
            Meses mes7 = new Meses();
            mes7.Mes = "Febrero";
            mes7.Dias = 31;

            MessageBox.Show(mes7.ToString());
        }

        private void btnAgosto_Click(object sender, EventArgs e)
        {
            Meses mes8 = new Meses();
            mes8.Mes = "Agosto";
            mes8.Dias = 31;

            MessageBox.Show(mes8.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Meses mes9 = new Meses();
            mes9.Mes = "sebtiembre";
            mes9.Dias = 30;

            MessageBox.Show(mes9.ToString());
        }

        private void btnNoviembre_Click(object sender, EventArgs e)
        {
            Meses Mes11 = new Meses();
            Mes11.Mes = "Noviembre";
            Mes11.Dias = 30;

            MessageBox.Show(Mes11.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Meses mes10 = new Meses();
            mes10.Mes = "Octubre";
            mes10.Dias = 31;
        }

        private void btnDiciembre_Click(object sender, EventArgs e)
        {
            Meses mes12 = new Meses();
            mes12.Mes = "Diciembre";
            mes12.Dias = 31;
        }
    }
}
