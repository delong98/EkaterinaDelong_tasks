using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace price_goods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Vitaly\Desktop\text6.txt");
            Console.WriteLine(text);

            string[] date = text.Split(new char[] { '.' });
            string[] punkt = null;
            int year = 0;
            int price = 0;
            int kolvo = 0;
            int sum = 0;


            for (int i = 0; i < date.Length - 1; i++)
            {
                string newDate = date[i];
                punkt = newDate.Split(new char[] { ';' });
                year = Convert.ToInt32(punkt[2]);
                if(year==2017)
                {
                    price = Convert.ToInt32(punkt[4]);
                    kolvo= Convert.ToInt32(punkt[3]);
                    sum =sum+(price*kolvo);
                    Console.WriteLine("Наименование: {0}\r\nИзготовитель: {1}\r\nГодвыпуска: {2}\r\nКоличество: {3}\r\nЦена: {4}\r\n", punkt[0], punkt[1], punkt[2], punkt[3], punkt[4]);
                }
            }

            Console.WriteLine("Общая стоимость товаров в 2017 году: " + sum);
            Console.ReadKey();
        }
    }
}
