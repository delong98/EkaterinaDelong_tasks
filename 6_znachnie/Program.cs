using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_znachnie
{
    class Program
    {
        static int Proverka(int i)
        {
            int levaya;
            int pravaya;
            int sumP = 0;
            int sumL = 0;
            int copyi = i;

            levaya = copyi / 1000;

            pravaya = copyi % 1000;

            for (int a = 2; a >= 0; a--)
            {
                sumL += levaya / (int)Math.Pow(10, a);
                levaya = levaya % (int)Math.Pow(10, a);
            }

            for (int b = 2; b >= 0; b--)
            {
                sumP += pravaya / (int)Math.Pow(10, b);
                pravaya = pravaya % (int)Math.Pow(10, b);
            }

            if (sumP == sumL)
            {
                Console.WriteLine("{0}-счастливое число", i);
            }
            return i;
        }



        static void Main(string[] args)
        {
            for (int i = 100000; i < 999999; i++)
            {

                int proverka = Proverka(i);
            }

            Console.ReadKey();
        }
    }
}
