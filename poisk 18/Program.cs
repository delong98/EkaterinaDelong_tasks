using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace poisk_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\text.txt");
            Console.WriteLine("Текст: " + text);
            string[] date = text.Split(new char[] { '.' });
            string[] punkt = null;

            for (int i = 0; i < date.Length - 1; i++)
            {
                string newDate = date[i];
                punkt = newDate.Split(new char[] { ';' });

                int znachenie = Convert.ToInt32(punkt[11]);

                if (znachenie == 18)
                {
                    Console.WriteLine("Фамилия: {0}\r\n имя: {1}\r\n отчество: {2}\r\n пол: {3}\r\n национальность: {4}\r\n рост: {5}\r\n вес: {6}\r\n дата рождения: {7}\r\n номер телефона: {8}\r\n домашний адрес: {9}\r\n номер больницы :  {10}\r\n отделение: {11}\r\n номер медицинской карты: {11}\r\n диагноз: {13}\r\n группа крови: {14}\r\n", punkt[0], punkt[1], punkt[2], punkt[3], punkt[4], punkt[5], punkt[6], punkt[7], punkt[8], punkt[9], punkt[10], punkt[11], punkt[12], punkt[13], punkt[14]);
                }
            }

        }
    }
}

