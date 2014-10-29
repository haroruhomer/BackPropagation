using System;
using System.Windows.Forms;

namespace BackPropagation
{
    public partial class Form1 : Form
    {
        double[] x=new double[2] {0.5,0.8};
        double[] y=new double[2] {0.4,0.6};
        double[,] wH = new double[2,2] {{0.01,0.01},
                                        {0.01,0.01}};
        double[,] wO = new double[2,2] {{0.01,0.01},
                                        {0.01,0.01}};
        double[,] wOAnt = new double[2, 2];
        double[,] wHAnt = new double[2, 2];
        Neurona[] neuronasH=new Neurona[2];
        Neurona[] neuronasO = new Neurona[2];
        private double errorG = 1;//ErrorGlobal
        private double net;
        private double salida;
        private double delta;
        private double alfa=0.1,beta=0.5;
        private double[,] deltaH = new double[2,2];

        public Form1()
        {
            InitializeComponent();
        }

        private void B_Resultado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                net = (wH[i, 0] * double.Parse(TB_X0.Text)) + (wH[i, 1] * double.Parse(TB_X1.Text));
                salida = 1 / (1 + Math.Pow(Math.E, -net));
                Neurona neuronaH = new Neurona("Oculta", net, salida);
                neuronasH[i] = neuronaH;

            }

            for (int j = 0; j < 2; j++)
            {
                net = (wO[j, 0] * neuronasH[0].salida) + (wO[j, 1] * neuronasH[1].salida);
                salida = 1 / (1 + Math.Pow(Math.E, -net));
                delta = (y[j] - salida) * (salida * (1 - salida));
                Neurona neuronaO = new Neurona("Salida", net, salida, delta);
                neuronasO[j] = neuronaO;
            }
            MessageBox.Show("1ra neurona "+neuronasO[0].salida.ToString() + " 2da neurona " + neuronasO[1].salida.ToString());
        }

        private void B_entrenar_Click(object sender, EventArgs e)
        {
            do
            {
                for (int i = 0; i < 2; i++)
                {
                    net = (wH[i,0] * x[0]) + (wH[i,1] * x[1]);
                    salida=1/(1+Math.Pow(Math.E,-net));
                    Neurona neuronaH = new Neurona("Oculta",net,salida);
                    neuronasH[i] = neuronaH;

                }

                for(int j = 0; j < 2; j++) 
                {
                    net = (wO[j, 0] * neuronasH[0].salida) + (wO[j, 1] * neuronasH[1].salida);
                    salida = 1 / (1 + Math.Pow(Math.E, -net));
                    delta=(y[j]-salida)*(salida*(1-salida));
                    Neurona neuronaO = new Neurona("Salida",net, salida,delta);
                    neuronasO[j] = neuronaO;
                }

                for (int k = 0; k < 2; k++)
                {
                    deltaH[k,0]=(x[0]*(1-x[0]))*((neuronasO[0].delta*wO[k,0])+(neuronasO[1].delta*wO[k,1]));
                    deltaH[k,1]=(x[1]*(1-x[1]))*((neuronasO[0].delta*wO[k,0])+(neuronasO[1].delta*wO[k,1]));
                }

                for (int l = 0; l < 2; l++)
                {
                    
                }
                for (int m = 0; m < 2; m++)
                {
                    wOAnt[m, 0] = wO[m, 0];
                    wO[m,0]=wO[m,0]+(alfa*(neuronasO[0].delta*neuronasO[m].salida));
                    wO[m, 0] = beta * (wO[m, 0] * wOAnt[m, 0]);
                    wOAnt[m, 1] = wO[m, 1];
                    wO[m, 1] = wO[m, 1] + (alfa * (neuronasO[1].delta * neuronasO[m].salida));
                    wO[m, 1] = beta * (wO[m, 1] * wOAnt[m, 1]);
                }

                for (int n = 0; n < 2; n++)
                {
                    wHAnt[n, 0] = wH[n, 0];
                    wH[n, 0] = wH[n, 0] + (alfa * (deltaH[n,0] * x[0]));
                    wH[n, 0] = beta * (wH[n, 0] * wHAnt[n, 0]);
                    wHAnt[n, 1] = wH[n, 1];
                    wH[n, 1] = wH[n, 1] + (alfa * (deltaH[n, 1] * x[1]));
                    wH[n, 1] = beta * (wH[n, 1] * wHAnt[n, 1]);
                }
                errorG = 1 / 2 * (Math.Pow(neuronasO[0].delta, 2) + Math.Pow(neuronasO[1].delta, 2));

            } while (errorG != 0);
        }

        private double Sumatoria()
        {

            throw new NotImplementedException();
        }
    }
}