using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadrat_mass
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            Random a = new Random();
            int n = gen.Next(2, 6);
            int[,] mas = new int[n, n];

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = gen.Next(0, 10);
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                sum += mas[i, n - 1];
            }
            Console.WriteLine("сумма эл-ов последнего столбца: " + sum);
            
            Console.ReadKey();
        }
    }
}
