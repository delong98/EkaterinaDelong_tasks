using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_string
{
    class ReadFromFile
    {
        static int Bukva(string smallText, string ш)
        {
            int count = 0;
            for (int i = 0; i < smallText.Length; i++)
            {
                if (smallText[i] == ш[0])
                {
                    count++;
                }
            }
            return count;
        }



        static double Procent(double bukva, double allBukvi)
        {
            return (bukva * 100 / allBukvi);
        }



        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\WriteText.txt");
            Console.WriteLine("Текст: " + text);

            string slova = text.Trim(new char[] { ',', '.', '5', '6', '4', '2', '—', '«', '»', '-' });
            string[] textSlova = slova.Split(new char[] { ' ' });
            Console.WriteLine("Количество слов: " + textSlova.Length);

            char[] textSimbol = text.ToCharArray();
            Console.WriteLine("Количество символов: " + textSimbol.Length);
            int copyTextSimbol = textSimbol.Length;

            string smallText = text.ToLower();
            Console.WriteLine("Текст нижним регистром: " + smallText);
            
            double bukva = Bukva(smallText, "ш");
            Console.WriteLine("Количество буквы: " + bukva);

            double allBukvi = smallText.Length;
            double procent = Procent(bukva, allBukvi);
            Console.WriteLine("Процентное выражение буквы среди символов:" + procent);

            Console.ReadKey();
        }
    }
}
