using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortirovka_znach
{
    struct PairForD
    {
        public string key;
        public int value;
    }

    class Program
    {
        
        static PairForD[] SortirovkaForValue(PairForD[] words, PairForD value, PairForD first, int znach)
        {
            PairForD a = first, b = value;
            if (value.value > first.value)
            {
                words[znach - 1] = b;
                words[znach] = a;
            }
            return words;
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\text5.txt");
            text = text.ToLower();
            string[] newText = text.Split(' ', '-', '.', ',', '(', ')', '"');

            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < newText.Length; i++)
            {
                if (newText[i] != "")
                {
                    string slovo = Convert.ToString(newText[i]);
                    if (!dictionary.ContainsKey(slovo))
                    {
                        dictionary[slovo] = 1;
                    }
                    else dictionary[slovo]++;
                }
            }

            int k = 0;

            foreach (var pair in dictionary)
            {
                k++;
            }

            PairForD[] wordsAndVal = new PairForD[k];
            int j = 0;

            foreach (var pair in dictionary)
            {
                wordsAndVal[j].key = pair.Key;
                wordsAndVal[j].value = pair.Value;
                j++;
            }

            for (int i = wordsAndVal.Length - 1; i > 0; i--)
            {
                int a = wordsAndVal[i - 1].value, b = wordsAndVal[i].value;
                if (a < b)
                {
                    PairForD first = wordsAndVal[0];
                    for (int n = 1; n < wordsAndVal.Length; n++)
                    {
                        wordsAndVal = SortirovkaForValue(wordsAndVal, wordsAndVal[n], first, n);
                        first = wordsAndVal[n];
                    }

                }
            }

            for (int i = 0; i < wordsAndVal.Length; i++)
            {
                Console.WriteLine(wordsAndVal[i].key + "\t" + wordsAndVal[i].value);
            }

            Console.ReadKey();
        }
    }
}
