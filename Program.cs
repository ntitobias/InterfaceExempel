using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExempel
{
    class Program
    {
        static void Main(string[] args)
        {
            ISumma summa = new Summa(3, 5);
            double resultat = summa.Addera();

            Console.WriteLine(resultat);



            summa = new Beräkning(3, 5);


            Console.ReadLine();
        }
    }
}
