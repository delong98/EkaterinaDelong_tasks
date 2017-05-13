using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolvo_elementov
{
    class Program
    {
        static int Count(int a, int[,] mas)
        {
            string elements = null;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                elements += mas[i, a];
            }
            return elements.Length;
        }
        static void Main(string[] args)
        {
            Random gen = new Random();
            int[,] mas = new int[3, 7];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = gen.Next(0, 10);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int a = 0;
            int elements1 = Count(a, mas);
            Console.WriteLine("количество элементов в столбце №1: "+elements1);

            a = 1;
            int elements2 = Count(a, mas);
            Console.WriteLine("количество элементов в столбце №2: " + elements2);

            a = 2;
            int elements3 = Count(a, mas);
            Console.WriteLine("количество элементов в столбце №3: " + elements3);

            a = 3;
            int elements4 = Count(a, mas);
            Console.WriteLine("количество элементов в столбце №4: " + elements4);

            a = 4;
            int elements5 = Count(a, mas);
            Console.WriteLine("количество элементов в столбце №5: " + elements5);

            a = 5;
            int elements6 = Count(a, mas);
            Console.WriteLine("количество элементов в столбце №6: " + elements6);

            a = 6;
            int elements7 = Count(a, mas);
            Console.WriteLine("количество элементов в столбце №7: " + elements7);

            Console.ReadKey();

        }
    }
}
