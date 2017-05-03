using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace last_znachenie
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Екатерина\Desktop\text3.txt");
            Console.WriteLine(text);
            string[] date = text.Split(new char[] { ',' });
            int a = date.Length;
            Console.WriteLine(date[a-1]);

            Console.ReadKey();
        }
    }
}
