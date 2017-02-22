using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            inicializarLista();
        }

        public double tpLlegada = Double.MaxValue;
        public double tpLimpiezaProgramada = Double.MaxValue;
        public double tpLimpiezaBanco = Double.MaxValue;
        public double tpLimpiezaAysa = Double.MaxValue;
        public double tpLimpiezaSeguro = Double.MaxValue;
        List<double> listaTiempos = new List<double>();
        double tiempoActual = 0;
        double tiempoFinal = 162000000; // En milisegundos
        int llegadasTotales = 0;

        //Inicializo
        public void inicializarLista()
    {
            listaTiempos.Add(tpLimpiezaAysa);
            listaTiempos.Add(tpLimpiezaBanco);
            listaTiempos.Add(tpLimpiezaProgramada);
            listaTiempos.Add(tpLimpiezaSeguro);
            listaTiempos.Add(tpLlegada);
    }
        

        private void btnSimular_Click(object sender, EventArgs e)
        {
            lblResultados.Visible = true;
            lblCVLU.Visible = true;
            lblPTE2LU.Visible = true;
            lblPDNA.Visible = true;
            tpLimpiezaProgramada = tiempoActual + (Convert.ToDouble(txtTLP.Text)*1000);
            tpLlegada = (calcularLlegadaMañanera(tiempoActual));
            ejecutarSimulacion(Convert.ToInt32(txtGbAysa.Text), Convert.ToInt32(txtGbBanco.Text), Convert.ToInt32(txtGbSeguro.Text), Convert.ToDouble(txtTLP.Text));
            btnSimular.Text = "Volver a Simular";
        }

        private double calcularLlegadaMañanera(double tiempo)
        {
            //Valores devueltos por el EasyFit para funcion de Frechet
            double alfa = 3.2786;
            double beta = 811.79;
            double gama = 0;
            Random x = new Random();
            double random = x.Next(500, 3000);
            double milisegundosAAgregar = calcularArriboTurnoMañana(alfa, beta, gama, random);
            return milisegundosAAgregar + tiempo;

        }

        private double calcularArriboTurnoMañana(double alfa, double beta, double gama, double random)
        {
            double valorRetorno = (alfa / beta) * Math.Pow((beta / random - gama), alfa + 1) * Math.Exp(-(Math.Pow(beta / random - gama, alfa)));
            return valorRetorno;

        }

        private void ejecutarSimulacion(int GbAysa, int GbBanco, int GbSeguro, double TLP)
        {
            // 5 ESCENARIOS POSIBLES

            if (tpLlegada <= tpLimpiezaProgramada & tpLlegada <= tpLimpiezaAysa & tpLlegada <= tpLimpiezaBanco & tpLlegada <= tpLimpiezaSeguro)
            {
                //1
                tiempoActual += (tpLlegada - tiempoActual);
                llegadasTotales++;

            }

            else if (tpLimpiezaProgramada <= tpLimpiezaAysa & tpLimpiezaProgramada <= tpLimpiezaSeguro & tpLimpiezaProgramada <= tpLimpiezaBanco)
            {
                //2
                tiempoActual += tpLimpiezaProgramada;
            }

            else if (tpLimpiezaAysa <= tpLimpiezaBanco & tpLimpiezaAysa <= tpLimpiezaSeguro)
            {
                //3
                tiempoActual += tpLimpiezaAysa;
            }

            else if (tpLimpiezaBanco <= tpLimpiezaSeguro)
            {
                //4
                tiempoActual += tpLimpiezaBanco;
            }
            
            else
            {
                //5
                tiempoActual += tpLimpiezaSeguro;
            }
          


            while (tiempoActual < tiempoFinal)
            {
               
            }
        }
    }
}
