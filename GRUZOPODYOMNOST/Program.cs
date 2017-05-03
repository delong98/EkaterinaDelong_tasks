using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GRUZOPODYOMNOST
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\text1.txt");
            Console.WriteLine("Текст: " + text);
            string[] date = text.Split(new char[] { '.' });
            string[] punkt = null;

            for (int i = 0; i < date.Length - 1; i++)
            {
                string newDate = date[i];
                punkt = newDate.Split(new char[] { ';' });

                int znachenie = Convert.ToInt32(punkt[3]);

                if (znachenie > 2)
                {
                    Console.WriteLine("Марка автомобиля: {0}\r\nномер автомобиля: {1}\r\nпункт назначения: {2}\r\nгрузоподъемность(в тоннах): {3}\r\nстоимость единицы груза: {4}\r\nобщая стоимость груза: {5}\r\n", punkt[0], punkt[1], punkt[2], punkt[3], punkt[4], punkt[5]);
                }
            }
            Console.ReadKey();
        }
    }
}
