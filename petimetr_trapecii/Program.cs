using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petimetr_trapecii
{
    class Program
    {
        static double BokovayaStorona(double verhnyaStorona, double nijnyaStorona, double visota)
        {
            double raznost = Math.Abs(verhnyaStorona - nijnyaStorona);
            double bokovayaStorona = Math.Sqrt(Math.Pow((raznost / 2), 2) + Math.Pow(visota, 2));
            return bokovayaStorona;
        }


        static double Perimetr(double verhnyaStorona, double nijnyaStorona, double bokovayaStorona)
        {
            double perimetr = verhnyaStorona + nijnyaStorona + bokovayaStorona + bokovayaStorona;
            return perimetr;
        }


        static void Main(string[] args)
        {
            double nijnyaStorona = 13;
            double verhnyaStorona = 3;
            double visota = 4;
            double bokovayaStorona = BokovayaStorona( verhnyaStorona, nijnyaStorona, visota);
            Console.WriteLine("Боковая сторона 1 трапеции={0}", bokovayaStorona);
            double perimetr1 = Perimetr(verhnyaStorona, nijnyaStorona, bokovayaStorona);
            Console.WriteLine("Периметр={0}", perimetr1);

            nijnyaStorona = 10;
            verhnyaStorona = 4;
            visota = 2;
            bokovayaStorona = BokovayaStorona(verhnyaStorona, nijnyaStorona, visota);
            Console.WriteLine("Боковая сторона 2 трапеции={0}", bokovayaStorona);
            double perimetr2 = Perimetr(verhnyaStorona, nijnyaStorona, bokovayaStorona);
            Console.WriteLine("Периметр={0}", perimetr2);


            double sum = perimetr1 + perimetr1;
            Console.WriteLine("Сумма периметров={0}", sum);


            Console.ReadKey();
        }
    }
}
