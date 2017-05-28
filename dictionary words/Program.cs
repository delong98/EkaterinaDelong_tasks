using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_words
{
    class Program
    {
        static string[] Poisk(string[] allWords, int znach, out string[] copy)
        {

            copy = null;
            int ind=-1;
            string min = null;
            string first=null;
            string second=null;
            first = allWords[znach];
            for (int i = znach; i < allWords.Length-1; i++)
            {
                second = allWords[i + 1];
                if (first.Length >= second.Length)
                {
                    
                    for (int k = 0; k < second.Length; k++)
                    {
                        if (first[k] == second[k])
                        {
                            continue;
                        }
                        if (first[k] < second[k])
                        {
                            
                            break;
                        }
                        else
                        {
                            first = second;
                            ind = i;
                            break;
                        }
                    }
                }
                else
                {
                    
                    for (int n = 0; n < first.Length; n++)
                    {
                        if (first[n] < second[n])
                        {
                            
                            break;
                        }
                        if (first[n] == second[n])
                        {
                            continue;
                        }
                        else
                        {
                            first = second;
                            ind = i;
                            break;
                        }
                    }
                }

            }
            min = first;
            string zamena=allWords[znach];
            allWords[znach] = min;
            allWords[ind+1] = zamena;
           
            copy = allWords;
            //copy[1] = "было";
            return copy;
            


        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Екатерина\Desktop\text5.txt");
            text = text.ToLower();
            string[] newText = text.Split(' ', '-', '.', ',','(', ')', '"');

            string allTetxt = null;

            for (int i = 0; i <newText.Length; i++)
            {
                if (newText[i]!="")
                {
                    allTetxt += newText[i] + ",";
                }
                
            }
            Console.WriteLine(allTetxt);

            string[] allWords = allTetxt.Split(',');

            
            


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

            string words = null;
            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
                words += pair.Key + ',';
            }
            words = words.ToLower();








            int znach = 1;
            string[] copy = null;
            for (int i = 0; i < allWords.Length-1; i++)
            {

                copy = Poisk(allWords, znach, out copy);
                
                allWords = copy;
                
                znach++;
            }
            
            
            for (int i = 0; i < allWords.Length-1; i++)
            {
                Console.WriteLine(allWords[i]);
            }

            




            Console.ReadKey();
        }
    }
}
