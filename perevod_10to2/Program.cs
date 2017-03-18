using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perevod_10to2
{
    class Program
    {
        static string Perevod (int a)
        {
            int chislo=0;
            int copya = a;
            string perevod="";
            while (copya>0)
            {
                copya = copya / 2;
                chislo = copya % 2;
                
                perevod =perevod+chislo.ToString();
                
            }
            return perevod;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число а из десятичной СС");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            string perevod = Perevod(a);
            Console.WriteLine("Ваше число в двоичной СС={0}", perevod);//вывод ответа

            Console.ReadKey();
        }
    }
}
