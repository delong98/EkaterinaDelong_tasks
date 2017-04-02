using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_string
{
    class ReadFromFile
    {
        static bool SearchInUnique(string uniqueStr, char copysimbol)
        {
            for (int i = 0; i < uniqueStr.Length; i++)
            {
                if (uniqueStr[i] == copysimbol)
                {
                    return false;
                }
            }
            return true;
        }



        static int Count(string smallText, string simbol)
        {
            int count = 0;
            for (int i = 0; i < smallText.Length; i++)
            {
                if (smallText[i] == simbol[0])
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

            string simbol = "ш";
            char copysimbol = Convert.ToChar(simbol);
            double count = Count(smallText, simbol);
            Console.WriteLine("Количество буквы: " + count);

            double allBukvi = smallText.Length;
            double procent = Procent(count, allBukvi);
            Console.WriteLine("Процентное выражение буквы среди символов:" + procent);

            string uniqueChar = "";

            foreach (char i in smallText)
            {
                if (uniqueChar.Length == 0)
                {
                    uniqueChar = uniqueChar + i;
                }
                else
                {
                    bool lokal = SearchInUnique(uniqueChar, i);
                    if (lokal)
                    {
                        uniqueChar = uniqueChar + i;

                    }
                }

            }
            Console.WriteLine("Уникальные символы: " + uniqueChar);


            Console.ReadKey();
        }
    }
}
    
