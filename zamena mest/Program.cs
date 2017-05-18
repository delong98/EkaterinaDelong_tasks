using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamena_mest
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\text1.txt");
            Console.WriteLine("Текст: " + text);
            string[] newMas = text.Split('.');
            string[] element = null;
            int[][] mas = new int[4][];
            mas[0] = new int[3];
            mas[1] = new int[3];
            mas[2] = new int[3];
            mas[3] = new int[3];

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

            string stolb1 = null;
            string stolb3 = null;

            for (int i = 0; i < 4; i++)
            {
                stolb1 += Convert.ToString(mas[i][0]) + ";";
            }
            Console.WriteLine(stolb1);

            string[] newStolb1 = stolb1.Split(new char[] { ';' });
            int max = Convert.ToInt32(newStolb1[0]);
            int i1 = 0;
            int max1 = 0;
            for (int i = 1; i < newStolb1.Length - 1; i++)
            {

                if (max < Convert.ToInt32(newStolb1[i]))
                {
                    i1 = i;
                    max = Convert.ToInt32(newStolb1[i]);
                    continue;
                }
                else
                {
                    max1 = Convert.ToInt32(newStolb1[i1]);
                }
            }
            Console.WriteLine(max1);


            for (int j = 0; j < 4; j++)
            {
                stolb3 += Convert.ToString(mas[j][2]) + ";";
            }
            Console.WriteLine(stolb3);

            string[] newStolb3 = stolb3.Split(new char[] { ';' });
            int max0 = Convert.ToInt32(newStolb3[0]);
            int i3 = 0;
            int max3 = 0;
            for (int i = 1; i < newStolb3.Length - 1; i++)
            {

                if (max0 < Convert.ToInt32(newStolb3[i]))
                {
                    i3 = i;
                    max0 = Convert.ToInt32(newStolb3[i]);
                    continue;
                }
                else
                {
                    max3 = Convert.ToInt32(newStolb3[i3]);
                }
            }
            Console.WriteLine(max3);

            int zapas = 0;
            zapas = mas[i1][0];
            mas[i1][0] = mas[i3][2];
            mas[i3][2] = zapas;

            for (int i = 0; i < newMas.Length; i++)
            {
                for (int j = 0; j < element.Length; j++)
                {
                    Console.Write(mas[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
