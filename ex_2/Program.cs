using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2
{
    class Program
    {
        static double Drob(double chislitel)
        {
            double y = (chislitel + Math.Sin(chislitel)) / 3;
            return y;
        }


        static void Main(string[] args)
        {
            double chislitel = 1;
            double y = Drob(chislitel);
            double y1 = y;

            Console.WriteLine("y1={0}", y1);

            chislitel = chislitel + 2;
            y = Drob(chislitel);
            double y2 = y;

            Console.WriteLine("y2={0}", y2);

            chislitel = chislitel + 2;
            y = Drob(chislitel);
            double y3 = y;

            Console.WriteLine("y3={0}", y3);

            double sum = y1 + y2 + y3;

            Console.WriteLine("sum={0}", sum);


            Console.ReadKey();
        }

    }
}