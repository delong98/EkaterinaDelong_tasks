using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\text5.txt");
            text = text.ToLower();
            Console.WriteLine(text);

            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string symbol = Convert.ToString(text[i]);
                if (symbol != " ")
                {
                    if (!dictionary.ContainsKey(symbol))
                    {
                        dictionary[symbol] = 1;
                    }
                    else dictionary[symbol]++;
                }
            }


            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }


            Console.ReadKey();
        }
    }
}
