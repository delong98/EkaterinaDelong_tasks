using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slovari
{
    class Program
    {
        static void Main(string[] args)
        {
            string text=System.IO.File.ReadAllText(@"C:\Users\Vitaly\Desktop\text1.txt");
            Console.WriteLine(text);

            text = text.ToLower();
            string[] newText = text.Split(new char[] { ' ',',', '.', '"' });
            string newText1 = null;

            Console.WriteLine();

            for (int i = 0; i < newText.Length; i++)
            {
                newText1 += newText[i];
            }

            Console.WriteLine(newText1);

            

            int count = 0;
            string unic = null;
            for (int i = 1; i < newText.Length; i++)
            {
                for (int j = 0; j < newText.Length; j++)
                {
                    if (newText[j] == newText[i])
                    {
                        count++;
                    }
                }
                if (count==0)
                {
                    unic += newText[i] + ";";
                }
            }
            Console.WriteLine(unic);


            Console.ReadKey();
        }
    }
}
