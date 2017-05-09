using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\text2.txt");
            Console.WriteLine("Текст: " + text);
            string[] date = text.Split(new char[] { '.' });
            string[] punkt = null;

            for (int i = 0; i < date.Length - 1; i++)
            {
                string newDate = date[i];
                punkt = newDate.Split(new char[] { ';' });

                string znachenie = punkt[0];
                string newZnachenie = znachenie.ToLower();
                
                if (newZnachenie == "уссурийский тигр")
                {
                    Console.WriteLine("Название животного: {0}\r\nколичество вида: {1}\r\nадрес зоопарка: {2}\r\nобщее количество животных(в тоннах): {3}\r\nколичество работников: {4}\r\n", punkt[0], punkt[1], punkt[2], punkt[3], punkt[4]);
                }
            }
            Console.ReadKey();
        }
    }
}
