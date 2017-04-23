using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polindrom_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\WriteText.txt");
            Console.WriteLine("Текст: " + text);
            string smallText = text.ToLower();
            string slova = smallText.Trim(new char[] { ',', '.', '5', '6', '4', '2', '—', '«', '»', '-' });
            string[] textSlova = slova.Split(new char[] { ',', '.', '(', ')', ' ', '5', '6', '4', '2', '—', '«', '»', '-' });

            string palondrom = null;
            for (int i = 0; i < textSlova.Length; i++)
            {
                string slovo = textSlova[i];
                int t = 0;
                if (textSlova[i].Trim() != "")
                {
                    if (slovo.Length != 1)
                    {
                        if (slovo.Length % 2 == 0)
                        {
                            for (int a = 0; a < (slovo.Length / 2); a++)
                            {
                                char bukva1 = slovo[a];
                                int b = slovo.Length - 1;

                                char bukva2 = slovo[b - a];
                                if (bukva1 == bukva2)
                                {
                                    t = t + 1;
                                }
                            }

                            if (t == slovo.Length / 2)
                            {
                                palondrom = palondrom + slovo + " ";
                            }
                        }

                        else
                        {
                            for (int a = 0; a < ((slovo.Length - 1) / 2); a++)
                            {
                                char bukva1 = slovo[a];
                                int b = slovo.Length - 1;

                                char bukva2 = slovo[b - a];
                                if (bukva1 == bukva2)
                                {
                                    t = t + 1;
                                }
                            }

                            if (t == slovo.Length / 2)
                            {
                                palondrom = palondrom + slovo + " ";
                            }
                        }
                    }
                }
            }
            Console.WriteLine(palondrom);

            Console.ReadKey();
        }
    }
}
