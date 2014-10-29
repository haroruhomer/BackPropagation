using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPropagation
{
    class Neurona
    {
        //private double net;
        //private double salida;
        public string clase { get; set; }
        public double net { get; set; }
        public double salida { get; set; }
        public double delta { get; set; }
        public Neurona(string clase, double net,double salida)
        {
            this.clase = clase;
            this.net = net;
            this.salida = salida;
        }

        public Neurona(string clase, double net, double salida,Double delta)
        {

            this.clase = clase;
            this.net = net;
            this.salida = salida;
            this.delta = delta;
        }
    }
}
