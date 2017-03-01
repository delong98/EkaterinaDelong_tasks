using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetr_treugolnika_po_koordinatam
{
    class Program
    {
        static double Rasstoyanie(double x1, double y1, double x2, double y2)
        {
            double rasstoyanie = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            

            return rasstoyanie;
        }


        static void Main(string[] args)
        {
            double x1 = 3, y1 = 3;//A
            double x2 = 2, y2 = 1;//B
            double rasstoyanieAB = Rasstoyanie(x1, x2, y1, y2);
            Console.WriteLine("Расстояние от А до В={0}", rasstoyanieAB);

            x1 = 5;//C
            y1 = 5;//
            double rasstoyanieBC= Rasstoyanie(x1, x2, y1, y2);
            Console.WriteLine("Расстояние от B до C={0}", rasstoyanieBC);

            x1 = 3;
            y1 = 3;
            x2 = 4;
            y2 = 1;
            double rasstoyanieAC = Rasstoyanie(x1, x2, y1, y2);
            Console.WriteLine("Расстояние от A до C={0}", rasstoyanieAC);

            double perimetr = rasstoyanieAB + rasstoyanieAC + rasstoyanieBC;
            Console.WriteLine("Периметр={0}", perimetr);

            Console.ReadKey();





        }
    }
}
