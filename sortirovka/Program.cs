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

            int element1 = 0;
            string allElements1 = null;

            int element2 = 0;
            string allElements2 = null;

            int element3 = 0;
            string allElements3 = null;


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


            string[] punkt = null;
            punkt = allElements.Split(new char[] { ';' });

            int min0 = Convert.ToInt16(punkt[0]);
            int i0 = 0;
            int zapas0 = 0;


            for (int i = 1; i < punkt.Length - 1; i++)
            {

                if (min0 > Convert.ToInt16(punkt[i]))
                {
                    i0 = i;
                    min0 = Convert.ToInt16(punkt[i0]);
                    continue;
                }
                
                else
                
                {
                    zapas0 = mas[0, 3];
                }
            }
            mas[i0, 3] = zapas0;
            mas[0, 3] = min0;

            //Console.WriteLine(mas[0, 3]);
            //Console.WriteLine(mas[1, 3]);
            //Console.WriteLine(mas[2, 3]);
            //Console.WriteLine(mas[3, 3]);
            //Console.WriteLine(mas[4, 3]);


            for (int i = 1; i < mas.GetLength(0); i++)
            {
                element1 = mas[i, 3];
                allElements1 += Convert.ToString(element1) + ";";

            }
            
            string[] punkt1 = null;
            punkt1 = allElements1.Split(new char[] { ';' });

            int min1 = Convert.ToInt16(punkt1[0]);
            int i1 = 0;
            int zapas1 = 0;


            for (int i = 1; i < punkt1.Length - 1; i++)
            {

                if (min1 > Convert.ToInt16(punkt1[i]))
                {
                    i1 = i;
                    min1 = Convert.ToInt16(punkt1[i1]);
                    continue;
                }

                else

                {
                    zapas1 = mas[1, 3];
                }
            }
            mas[i1+1, 3] = zapas1;
            mas[1, 3] = min1;

            //Console.WriteLine(mas[0, 3]);
            //Console.WriteLine(mas[1, 3]);
            //Console.WriteLine(mas[2, 3]);
            //Console.WriteLine(mas[3, 3]);
            //Console.WriteLine(mas[4, 3]);


            for (int i = 2; i < mas.GetLength(0); i++)
            {
                element2 = mas[i, 3];
                allElements2 += Convert.ToString(element2) + ";";
            }
            
            string[] punkt2 = null;
            punkt2 = allElements2.Split(new char[] { ';' });

            int min2 = Convert.ToInt16(punkt2[0]);
            int i2 = 0;
            int zapas2 = 0;


            for (int i = 1; i < punkt2.Length - 1; i++)
            {

                if (min2 > Convert.ToInt16(punkt2[i]))
                {
                    i2 = i;
                    min2 = Convert.ToInt16(punkt2[i2]);
                    continue;
                }

                else

                {
                    zapas2 = mas[2, 3];
                }
            }
            mas[i2+2, 3] = zapas2;
            mas[2, 3] = min2;

            //Console.WriteLine(mas[0, 3]);
            //Console.WriteLine(mas[1, 3]);
            //Console.WriteLine(mas[2, 3]);
            //Console.WriteLine(mas[3, 3]);
            //Console.WriteLine(mas[4, 3]);

            for (int i = 3; i < mas.GetLength(0); i++)
            {
                element3 = mas[i, 3];
                allElements3 += Convert.ToString(element3) + ";";
            }
            
            string[] punkt3 = null;
            punkt3 = allElements3.Split(new char[] { ';' });

            int zapas3 = 0;

            if (Convert.ToInt16(mas[3,3]) > Convert.ToInt16(mas[4,3]))
            {
                zapas3 = mas[3, 3];
                mas[3, 3] = mas[4,3];
                mas[4, 3] = zapas3;
            }
            else
            {
                mas[4, 3] = mas[4,3];
                mas[3, 3] = mas[3, 3];
            }

            //Console.WriteLine(mas[0, 3]);
            //Console.WriteLine(mas[1, 3]);
            //Console.WriteLine(mas[2, 3]);
            //Console.WriteLine(mas[3, 3]);
            //Console.WriteLine(mas[4, 3]);

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
