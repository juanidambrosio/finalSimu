using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            lblResultados.Visible = true;
            lblCVLU.Visible = true;
            lblPTE2LU.Visible = true;
            lblPDNA.Visible = true;
            btnSimular.Text = "Volver a Simular";
            ejecutarSimulacion(Convert.ToInt32(txtGbAysa.Text), Convert.ToInt32(txtGbBanco.Text), Convert.ToInt32(txtGbSeguro.Text), Convert.ToInt32(txtTLP.Text));
        }

        private void ejecutarSimulacion(int GbAysa, int GbBanco, int GbSeguro, int TLP)
        {
            int tiempoInicial = 0;
            int tiempoFinal = 50000; // Realmente es así o se parametriza?

            while (tiempoInicial < tiempoFinal)
            {
               
            }
        }
    }
}
