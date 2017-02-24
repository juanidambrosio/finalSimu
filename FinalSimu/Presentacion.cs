using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
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
        double documentosTotales = 0;
        double tiempoUltimaLimpiezaUrgencia = 0;

        //Variables de estado
        double almacenamientoAysa = 0;
        double almacenamientoSeguro = 0;
        double almacenamientoBanco = 0;
        byte ILU = 0;

        //Resultados
        double cantidadLimpiezasUrgencia = 0;
        double tiempoTotalEntreLimpiezaUrgencia = 0;
        double totalDocumentosNoAlmacenados = 0;
        double porcentajeDocumentosNoAlmacenados = 0;
        double promedioTiempoEntreLimpiezas = 0;

        //Milisegundos para calculo por día
        double milisegDia = 32400000;
        double milisegLimiteIAM = 18000000;

        //Variables de calculo
        //TDD 
        double alfaTamanio = 3.1911;
        double betaTamanio = 106.81;
        double gammaTamanio = 257.35;
        //IAM
        double aIAM = 497.29;
        double bIAM = 4323.9;
        double mIAM = 1016.6;
        //IAT
        double alfa1IAT = 1.1802;
        double alfa2IAT = 1.0741;
        double aIAT = 1000;
        double bIAT = 4000;

        Chart chart = new Chart();

        private void btnSimular_Click(object sender, EventArgs e)
        {
            
            tpLimpiezaProgramada = tiempoActual + (Convert.ToDouble(txtTLP.Text) * 1000);
            tpLlegada = (calcularLlegadaMañanera());
            //Ejecucion de simulacion teniendo en cuenta las variables de control
            while(tiempoActual< tiempoFinal)
            {
                ejecutarSimulacion(Convert.ToInt32(txtGbAysa.Text), Convert.ToInt32(txtGbBanco.Text), Convert.ToInt32(txtGbSeguro.Text), Convert.ToDouble(txtTLP.Text), Convert.ToDouble(txtPorcentajeLimpieza.Text));
            }
            porcentajeDocumentosNoAlmacenados = ( totalDocumentosNoAlmacenados / documentosTotales) * 100;

            promedioTiempoEntreLimpiezas = tiempoTotalEntreLimpiezaUrgencia / cantidadLimpiezasUrgencia;

            lblCVLU.Text = string.Concat(lblCVLU.Text, cantidadLimpiezasUrgencia.ToString());
            lblPDNA.Text = string.Concat(lblPDNA.Text, porcentajeDocumentosNoAlmacenados.ToString());
            lblPTE2LU.Text = string.Concat(lblPTE2LU.Text, promedioTiempoEntreLimpiezas.ToString());

            btnSimular.Text = "Volver a Simular";
            lblResultados.Visible = true;
            lblCVLU.Visible = true;
            lblPTE2LU.Visible = true;
            lblPDNA.Visible = true;
            
         
         
        }

        private double calcularLlegadaMañanera()
        {   
            Random x = new Random();
            double miliSegundosAAgregar = x.Next(500, 3000);
            Random y = new Random();
            double random = y.NextDouble() * 0.138;
            double probabilidad = calcularFuncionPert(aIAM,bIAM,miliSegundosAAgregar,mIAM);
            if (random <= probabilidad)
            {
                return miliSegundosAAgregar;
            }
            else return calcularLlegadaMañanera();

        }


        private double calcularLlegadaTardia( )
        {
            Random x = new Random();
            double miliSegundosAAgregar = x.Next(1000,4000);
            Random y = new Random();
            double random = y.NextDouble() * 0.087;
            double probabilidad = calcularFuncionBeta(alfa1IAT, alfa2IAT, aIAT,bIAT, miliSegundosAAgregar);

            if (random <= probabilidad)
            {
                return miliSegundosAAgregar;
            }

            else return calcularLlegadaTardia();
            
        }

        private double calcularFuncionBeta(double alfa1, double alfa2, double a, double b, double random)
        {
            
            double numerador = Math.Pow(random - a, alfa1 - 1) * Math.Pow(b - random, alfa2 - 1);
            double denominador = chart.DataManipulator.Statistics.BetaFunction(alfa1, alfa2) * Math.Pow(b - a, alfa1 + alfa2 - 1);
            return (numerador / denominador)*250;
        }

        private double calcularFuncionGamma(double alfa, double beta, double gamma, double random)
        {
           
            double numerador = Math.Pow(random - gamma, alfa - 1) * Math.Exp(-(random - gamma) / beta);
            double denominador = Math.Pow(beta, alfa) * chart.DataManipulator.Statistics.GammaFunction(alfa);
            return (numerador/denominador)*100;
        }

        private double calcularFuncionPert(double a,double b, double random, double m)
        {
            
            double alfa1 = (4*m + b - 5*a)/ (b - a);
            double alfa2 = (5 * b - a - 4 * m) / (b - a);
            double valorFuncionBeta = chart.DataManipulator.Statistics.BetaFunction(alfa1, alfa2);
            double valorMultiplicado = (1 / valorFuncionBeta) * Math.Pow(random - a, alfa1 - 1) * Math.Pow(b - random, alfa2 - 1);
            double valorRetorno = valorMultiplicado / Math.Pow(b - a, alfa1 + alfa2 - 1) * 200;
            return valorRetorno;
        }

        private double calcularTamanioDocumento()
        {
            double alfaTamanio = 3.1911;
            double betaTamanio = 106.81;
            double gammaTamanio = 257.35;
            Random x = new Random();
            double tamanioAAgregar = x.Next(300, 1200);
            Random y = new Random();
            double random = y.NextDouble() * 0.2 ;
            double probabilidad = calcularFuncionGamma(alfaTamanio, betaTamanio, gammaTamanio, tamanioAAgregar);

            if (random <= probabilidad)
            {
                return tamanioAAgregar;
            }

            else return calcularTamanioDocumento();
        }

        private double actualizarIndicadoresLimpiezaUrgencia(double tpLimpieza)
        {
            if (ILU == 0)
            {
                tpLimpieza = tiempoActual + 3000;
                cantidadLimpiezasUrgencia++;
                ILU = 1;
                tiempoTotalEntreLimpiezaUrgencia += tiempoActual - tiempoUltimaLimpiezaUrgencia;
            }
            else totalDocumentosNoAlmacenados++;

            return tpLimpieza;
        }

        private void reducirAlmacenamiento(double tiempo, double almacenamiento)
        {
            tiempoUltimaLimpiezaUrgencia = tiempo;
            almacenamiento = almacenamiento * 0.9;
            ILU = 0;
        }
        private void ejecutarSimulacion(int GbAysa, int GbBanco, int GbSeguro, double TLP, double PLV)
        {
            // 5 ESCENARIOS POSIBLES

            if (tpLlegada <= tpLimpiezaProgramada & tpLlegada <= tpLimpiezaAysa & tpLlegada <= tpLimpiezaBanco & tpLlegada <= tpLimpiezaSeguro)
            {
                //1 - Entra por llegada de documento
                tiempoActual = tpLlegada;
                documentosTotales++;
                double horaAEvaluar = tiempoActual % milisegDia;

                if (horaAEvaluar <= milisegLimiteIAM)
                {
                    tpLlegada = tiempoActual + calcularLlegadaMañanera();
                }

                else tpLlegada = tiempoActual + calcularLlegadaTardia();

                double tamanioDocumento = calcularTamanioDocumento();
                Random x = new Random();
                double probabilidad = x.NextDouble();
                //Random para saber a donde llega el documento
                if (probabilidad <= 0.5)
                {
                    if (almacenamientoAysa + tamanioDocumento/1024 >= GbAysa * 1024)
                    {
                       tpLimpiezaAysa = actualizarIndicadoresLimpiezaUrgencia(tpLimpiezaAysa);
                    }
                    else almacenamientoAysa += tamanioDocumento/1024;
                }
                else if (probabilidad > 0.5 & probabilidad <= 0.8)
                {
                    if (almacenamientoBanco + tamanioDocumento >= GbBanco * 1024)
                    {
                       tpLimpiezaBanco = actualizarIndicadoresLimpiezaUrgencia(tpLimpiezaBanco);
                    }
                    else almacenamientoBanco += tamanioDocumento/1024;
                }
                else
                {
                    if (almacenamientoSeguro + tamanioDocumento/1024 >= GbSeguro * 1024)
                    {
                       tpLimpiezaSeguro = actualizarIndicadoresLimpiezaUrgencia(tpLimpiezaSeguro);
                    }
                    else almacenamientoSeguro += tamanioDocumento/1024;
                }
            }

            else if (tpLimpiezaProgramada <= tpLlegada & tpLimpiezaProgramada <= tpLimpiezaAysa & tpLimpiezaProgramada <= tpLimpiezaBanco & tpLimpiezaProgramada <= tpLimpiezaSeguro)
            {
                //2 - Entra por limpieza programada
                tiempoActual += tpLimpiezaProgramada;
                tpLimpiezaProgramada += TLP;
                almacenamientoAysa -= almacenamientoAysa* PLV/100;
                almacenamientoBanco = almacenamientoBanco * PLV / 100;
                almacenamientoSeguro = almacenamientoSeguro * PLV / 100;
            }

            else if (tpLimpiezaAysa <= tpLlegada & tpLimpiezaAysa <= tpLimpiezaProgramada & tpLimpiezaAysa <= tpLimpiezaBanco & tpLimpiezaAysa <= tpLimpiezaSeguro)
            {
                //3 - Entra por limpieza de urgencia de Aysa
                tiempoActual += tpLimpiezaAysa;
                reducirAlmacenamiento(tpLimpiezaAysa,almacenamientoAysa);

            }

            else if (tpLimpiezaBanco <= tpLlegada & tpLimpiezaBanco <= tpLimpiezaProgramada & tpLimpiezaBanco <= tpLimpiezaAysa & tpLimpiezaBanco <= tpLimpiezaSeguro)
            {
                //4
                tiempoActual += tpLimpiezaBanco;
                reducirAlmacenamiento(tpLimpiezaBanco, almacenamientoBanco);
            }
            
            else
            {
                //5
                tiempoActual += tpLimpiezaSeguro;
                reducirAlmacenamiento(tpLimpiezaSeguro, almacenamientoSeguro);
            }

        }
    }
}
