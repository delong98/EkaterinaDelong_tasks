using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortirovka
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            
            
            int[,] mas = new int[5, 4];
            int element = 0;
            string allElements = null;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = gen.Next(0, 10);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                element = mas[i, 3];
                allElements +=  Convert.ToString(element)+";";
                
            }
            Console.WriteLine(allElements);
            string copyall = allElements;
            string[] punkt = null;
            punkt = allElements.Split(new char[] { ';' });
            int min = Convert.ToInt16(punkt[0]);

            int i1 = 0;
            for (int i = 1; i < punkt.Length-1; i++)
            {
                
                
                int b = Convert.ToInt16(punkt[i]);
                if (min>b)
                {
                    
                    min = b;
                    i1 = i;
                    continue;
                }
                else if (min==b)
                {
                    mas[i1, 3] = mas[0, 3];
                    mas[0, 3] = min;
                    

                }
                else
                {
                    mas[i1, 3] = mas[0, 3];
                    mas[0, 3] = min;
                    
                }
                
            }
            Console.WriteLine(mas[0, 3]);

            int i2 = 0;
            int min1 = Convert.ToInt16(punkt[1]);
            for (int i = 2; i < punkt.Length - 1; i++)
            {
                int c = Convert.ToInt16(punkt[i]);
                if (min1 > c)
                {
                    i2 = i;
                    min1 = c;
                    continue;
                }
                else if (min1 == c)
                {
                    mas[i2, 3] = mas[1, 3];
                    mas[1, 3] = min1;


                }
                else
                {
                    mas[i2, 3] = mas[1, 3];
                    mas[1, 3] = min1;

                }
            }

            Console.WriteLine(mas[1, 3]);

           

















            Console.ReadKey();
        }
    }
}
