using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min_and_max_slovo_in_text
{
    class Program
    {
        static int CountBukva(string slovo)
        {
            int kolvo = 0;
            kolvo = slovo.Length;
            return kolvo;
        }

        static int PoiskMax(string[] textSlova)
        {
            int max = 1;
            for (int i = 0; i < textSlova.Length; i++)
            {
                if (textSlova[i].Length > max)
                {
                    max = textSlova[i].Length;
                }
            }
            return max;
        }

        static int PoiskMin(string[] textSlova, int max)
        {
            int min = max;
            for (int i = 0; i < textSlova.Length; i++)
            {
                if (textSlova[i].Length < min)
                {
                    if (textSlova[i].Trim() != "")
                        min = textSlova[i].Length;
                }
            }
            return min;

        }



        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\text.txt");
            Console.WriteLine("Текст: " + text);
            string smallText = text.ToLower();
            string[] textSlova = smallText.Split(new char[] { ',', '.', '(', ')', ' ' });

            string slovaMax = null;
            int max = PoiskMax(textSlova);
            Console.WriteLine("максимальная длина слова " + max);
            string slovaMin = null;
            int min = PoiskMin(textSlova, max);
            Console.WriteLine("минимальная длина слова " + min);

            for (int i = 0; i < textSlova.Length; i++)
            {
                string slovo = Convert.ToString(textSlova[i]);
                int kolvo = CountBukva(slovo);
                Console.WriteLine("слово \"{0}\" \t имеет длину {1}", slovo, kolvo);
                if (textSlova[i].Length == max)
                {
                    slovaMax = slovaMax + " " + slovo;
                }
                if (textSlova[i].Length == min)
                {
                    slovaMin = slovaMin + " " + slovo;
                }
            }

            Console.WriteLine("Самые длинные слова: " + slovaMax);
            Console.WriteLine("Самые короткие слова: " + slovaMin);
            Console.ReadKey();
        }
    }
}
