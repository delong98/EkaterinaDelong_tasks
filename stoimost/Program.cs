using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace stoimost
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Vitaly\Desktop\text8.txt");
            Console.WriteLine(text);

            string[] date = text.Split(new char[] { '.' });
            string[] punkt = null;
            int stoimost = 0;

            for (int i = 0; i < date.Length; i++)
            {
                string newDate = date[i];
                punkt = newDate.Split(new char[] { ';' });
                stoimost += (Convert.ToInt16(punkt[4]));
                Console.WriteLine("Наименование компьютера: "+punkt[0]);
            }
            Console.WriteLine(stoimost);
            int srednStoimost = 0;
            srednStoimost = stoimost / (date.Length);
            Console.WriteLine("Средняя стоимость: " + srednStoimost);

            Console.ReadKey();
        }
    }
}
