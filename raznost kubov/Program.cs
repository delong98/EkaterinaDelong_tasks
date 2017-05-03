using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace raznost_kubov
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Екатерина\Desktop\text3.txt");
            Console.WriteLine(text);
            string[] date = text.Split(new char[] { ',' });
            double b = 0;
            double c = 0;
            double raznost = 0;
            for (int i = 0; i < date.Length; i=i+2)
            {
                b = Convert.ToInt32(date[i]);
                Console.WriteLine("первое число: " + b);
                c = Convert.ToInt32(date[i+1]);
                Console.WriteLine("второе число: " + c);
                raznost = (Math.Pow(b, 3)) - (Math.Pow(c, 3));
                Console.WriteLine("Разность: " + raznost);
                
            }
            

            Console.ReadKey();
        }
    }
}
