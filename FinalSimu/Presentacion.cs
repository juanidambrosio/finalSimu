using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
          
        }

        //Eventos
        public double tpLlegada = Double.MaxValue;
        public double tpLimpiezaProgramada = Double.MaxValue;
        public double tpLimpiezaBanco = Double.MaxValue;
        public double tpLimpiezaAysa = Double.MaxValue;
        public double tpLimpiezaSeguro = Double.MaxValue;
        double tiempoActual = 0;
        double tiempoFinal = 162000000; // En milisegundos
        int documentosTotales = 0;
        double tiempoUltimaLimpiezaUrgencia = 0;

        //Variables de estado
        double almacenamientoAysa = 0;
        double almacenamientoSeguro = 0;
        double almacenamientoBanco = 0;
        byte ILU = 0;

        //Resultados
        int cantidadLimpiezasUrgencia = 0;
        double tiempoTotalEntreLimpiezaUrgencia = 0;
        int totalDocumentosNoAlmacenados = 0;

        private void btnSimular_Click(object sender, EventArgs e)
        {
            lblResultados.Visible = true;
            lblCVLU.Visible = true;
            lblPTE2LU.Visible = true;
            lblPDNA.Visible = true;
            tpLimpiezaProgramada = tiempoActual + (Convert.ToDouble(txtTLP.Text)*1000);
            tpLlegada = (calcularLlegadaMañanera(tiempoActual));
            //Ejecucion de simulacion teniendo en cuenta las variables de control
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
            double milisegundosAAgregar = calcularFuncionFretchet(alfa, beta, gama, random);
            return milisegundosAAgregar + tiempo;

        }

        private double calcularFuncionFretchet(double alfa, double beta, double gama, double random)
        {
            double valorRetorno = (alfa / beta) * Math.Pow((beta / random - gama), alfa + 1) * Math.Exp(-(Math.Pow(beta / random - gama, alfa)));
            return valorRetorno;

        }

        private double calcularLlegadaTardia(double tiempo)
        {
            double alfa = 1.6946;
            double beta = 647.9;
            double gamma = 721.41;
            Random x = new Random();
            double random = x.Next(750,4000);
            double milisegundosAAgregar = calcularFuncionGamma(alfa, beta, gamma, random);
            return milisegundosAAgregar + tiempo;
        }

        private double calcularFuncionGamma(double alfa, double beta, double gamma, double random)
        {
            double valorRetorno = (gamma / Math.Pow(alfa, beta)) * Math.Pow(random,beta-1)* Math.Exp(-Math.Pow((random/alfa),beta)); //Sin dividir por funcion gama
            return valorRetorno;
        }

        private double calcularTamanioDocumento()
        {
            double alfa = 3.1911;
            double beta = 106.81;
            double gamma = 257.35;
            Random x = new Random();
            double random = x.Next(300, 1200);
            double tamanioAAgregar = calcularFuncionGamma(alfa, beta, gamma, random);
            return tamanioAAgregar/1024;
        }

        private void actualizarIndicadoresLimpiezaUrgencia(double tpLimpieza)
        {
            if (ILU == 0)
            {
                tpLimpieza = tiempoActual + 3000;
                cantidadLimpiezasUrgencia++;
                ILU = 1;
                tiempoTotalEntreLimpiezaUrgencia += tiempoActual - tiempoUltimaLimpiezaUrgencia;
            }
            else totalDocumentosNoAlmacenados++;
        }
        private void ejecutarSimulacion(int GbAysa, int GbBanco, int GbSeguro, double TLP)
        {
            // 5 ESCENARIOS POSIBLES

            if (tpLlegada <= tpLimpiezaProgramada & tpLlegada <= tpLimpiezaAysa & tpLlegada <= tpLimpiezaBanco & tpLlegada <= tpLimpiezaSeguro)
            {
                //1 - Entra por llegada de documento
                tiempoActual += (tpLlegada - tiempoActual);
                documentosTotales++;
                double milisegDia = 32400000;
                double milisegLimiteIAM = 18000000;
                double horaAEvaluar = tiempoActual % milisegDia;

                if (horaAEvaluar <= milisegLimiteIAM)
                {
                    tpLlegada = calcularLlegadaMañanera(tiempoActual);
                }

                else tpLlegada = calcularLlegadaTardia(tiempoActual);

                double tamanioDocumento = calcularTamanioDocumento();
                Random x = new Random();
                double probabilidad = x.NextDouble();
                //Random para saber a donde llega el documento
                if (probabilidad <= 0.5)
                {
                    if (almacenamientoAysa + tamanioDocumento >= GbAysa * 1024)
                    {
                        actualizarIndicadoresLimpiezaUrgencia(tpLimpiezaAysa);
                    }
                    else almacenamientoAysa += tamanioDocumento;
                }
                else if (probabilidad > 0.5 & probabilidad <= 0.8)
                {
                    if (almacenamientoBanco + tamanioDocumento >= GbBanco * 1024)
                    {
                        actualizarIndicadoresLimpiezaUrgencia(tpLimpiezaBanco);
                    }
                    else almacenamientoBanco += tamanioDocumento;
                }
                else
                {
                    if (almacenamientoSeguro + tamanioDocumento >= GbSeguro * 1024)
                    {
                        actualizarIndicadoresLimpiezaUrgencia(tpLimpiezaSeguro);
                    }
                    else almacenamientoSeguro += tamanioDocumento;
                }
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
