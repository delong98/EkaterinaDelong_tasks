using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace znachenie_y_by_metod
{
    class Program
    {
        static double Drob (double chislitel, double znamenatel)
        {
            double y = (chislitel + Math.Sin(chislitel)) / (Math.Sin(znamenatel) + znamenatel);
            return y;
        }
          
     
      
        static void Main(string[] args)
        {

            



            double chislitel = 2;
            double znamenatel=5;
            double y = Drob(chislitel, znamenatel);
            double y1 = y;
            
            

            Console.WriteLine("y1={0}", y1);
            
          
   
            chislitel = chislitel + 4;
            znamenatel = znamenatel - 2;
            y = Drob(chislitel, znamenatel);
            double y2 = y;
            


            Console.WriteLine("y2={0}", y2);
            
           

            chislitel = chislitel - 5;
            znamenatel = znamenatel + 1;
            y = Drob(chislitel, znamenatel);
            double y3 = y;
            

            Console.WriteLine("y3={0}", y3);
            

            double sum = y1 + y2 + y2;

            Console.WriteLine("sum={0}", sum);
          

            Console.ReadKey();

        }
    }
}
