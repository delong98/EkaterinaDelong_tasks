using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace poisk_year
{
    class Program
    {
        static int Poisk(int a1, int b1, int c1, int d1, int e1)
        {
            
            if ((a1 > b1) && (a1 > c1) && (a1 > d1) && (a1 > e1))
            {
                return a1;
            }
            else if ((b1> a1) && (b1 > c1) && (b1> d1) && (b1 > e1))
            {
                return b1;
            }
            else if ((c1 > b1) && (c1 > a1) && (c1 > d1) && (c1 > e1))
            {
                return c1;
            }
            else if ((d1 > b1) && (d1 > c1) && (d1 > a1) && (d1 > e1))
            {
                return d1;
            }
            else
            {
                return e1;
            }
            
            
            
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\text3.txt");
            Console.WriteLine(text);
            string[] date = text.Split(new char[] { ';' });
            string[] punkt = null;
            string znacheniya = null;

            for (int i = 0; i < date.Length-1; i++)
            {
                string newDate = date[i];
                punkt = newDate.Split(new char[] { '.' });
                znacheniya += punkt[2]+" ";
                
            }
            Console.WriteLine(znacheniya);
            string[] newZnachenie = znacheniya.Split(new char[] { ' ' });

            string a = newZnachenie[0];
            string b = newZnachenie[1];
            string c = newZnachenie[2];
            string d = newZnachenie[3];
            string e = newZnachenie[4];

            int a1 = Convert.ToInt32(a);
            int b1 = Convert.ToInt32(b);
            int c1 = Convert.ToInt32(c);
            int d1 = Convert.ToInt32(d);
            int e1 = Convert.ToInt32(e);

            int max = Poisk(a1, b1, c1, d1, e1);
            Console.WriteLine(max);


            Console.ReadKey();
        }
    }
}
