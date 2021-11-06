using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExempel
{
    interface ISumma
    {
        double Addera();
    }

    class Summa : ISumma
    {
        double a, b;
        public Summa(double a, double b) { this.a = a; this.b = b; }
        public double Addera() { return a+b; }
    }






    interface IDifferens
    {
        double Subtrahera();
    }
    interface IProdukt
    {
        double Multiplicera();
    }
    interface IKvot
    {
        double Dividera();
    }
    class Beräkning : ISumma, IDifferens, IProdukt, IKvot
    {
        double a, b;
        public Beräkning(double a, double b) { this.a = a; this.b = b; }
        public double Addera(){return a + b;}
        public double Subtrahera() { return a - b; }
        public double Multiplicera() { return a * b; }
        public double Dividera() { return a / b; }
    }
}
