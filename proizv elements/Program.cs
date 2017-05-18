using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proizv_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Vitaly\Desktop\text1.txt");
            Console.WriteLine("Текст: " + text);
            string[] newMas = text.Split('.');
            string[] element = null;
            int[][] mas = new int[4][];
            mas[0] = new int[4];
            mas[1] = new int[4];
            mas[2] = new int[4];
            mas[3] = new int[4];

            for (int i = 0; i < newMas.Length; i++)
            {
                string newMas1 = newMas[i];
                element = newMas1.Split(new char[] { ',' });
                for (int j = 0; j < element.Length; j++)
                {

                    int a = Convert.ToInt32(element[j]);
                    mas[i][j] = a;
                    Console.Write(mas[i][j] + "\t");
                }
                Console.WriteLine();
            }

            int proizvedenie = 1;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                proizvedenie = proizvedenie * Convert.ToInt32(mas[0][i]);
            }

            Console.WriteLine("проеизведение элементов 1 строки: " + proizvedenie);
            Console.ReadKey();
        }
    }
}
