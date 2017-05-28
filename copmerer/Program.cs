using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copmerer
{
    class Program
    {
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

            var l = dictionary.OrderBy(key => key.Key);
            var dic = l.ToDictionary((keyItem) => keyItem.Key, (valueItem) => valueItem.Value);

            foreach (var pair in dic)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }

            Console.ReadKey();
        }
    }
}
