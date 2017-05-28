using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparer1
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

            var l = dictionary.OrderBy(value => value.Value);
            var dic = l.ToDictionary((valueItem) =>valueItem.Key, (keyItem) => keyItem.Value);

            foreach (var pair in dic)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }

            Console.ReadKey();
        }
    }
}
