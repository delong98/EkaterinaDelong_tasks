using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace firma_of_comp
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Vitaly\Desktop\text7.txt");
            Console.WriteLine(text);

            string[] date = text.Split(new char[] { '.' });
            string[] punkt = null;
            string firma = null;

            for (int i = 0; i < date.Length - 1; i++)
            {
                string newDate = date[i];
                punkt = newDate.Split(new char[] { ';' });
                firma = punkt[0];
                int min = Convert.ToInt16(punkt[3]);
                if ("AMD"==firma)
                {
                    if (min > Convert.ToInt16(punkt[3]))
                    {
                        min = Convert.ToInt16(punkt[3]);
                        continue;
                    }
                    else
                        Console.WriteLine("Производитель: {0}\r\nОбъем ОП: {1}\r\nДата изготовления: {2}\r\nЦена: {3}\r\n", punkt[0], punkt[1], punkt[2], punkt[3]);

                    }
                }
            Console.ReadKey();
            }
        }
    }

