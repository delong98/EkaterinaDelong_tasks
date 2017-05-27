using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_words
{
    class Program
    {
        static string[] Poisk(string[] newText, int znach, out string[] copy)
        {

            copy = null;
            int ind=0;
            string min = null;
            string first=null;
            string second=null;
            first = newText[znach];
            for (int i = znach; i < newText.Length-1; i++)
            {
                if (newText[i+1]!="")
                {
                        second = newText[i + 1];
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

                
                
                
            }
            min = first;
            string zamena=newText[znach];
            newText[znach] = min;
            newText[ind+1] = zamena;
            copy = newText;
            return copy;
            


        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\vitaly\Desktop\text5.txt");
            text = text.ToLower();
            string[] newText = text.Split(' ', '-', '.', ',','(', ')', '"');

            string allTetxt = null;

            for (int i = 0; i <newText.Length; i++)
            {
                allTetxt += newText[i]+",";
            }
            Console.WriteLine(allTetxt);

            
            


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
            

            
            
            
            int znach = 0;
           
            
            
            string[] copy = null;
            for (int i = 0; i < newText.Length-1; i++)
            {

                if (newText[znach]!="")
                {
                    copy = Poisk(newText, znach, out copy);
                }
                newText = copy;
                
                znach++;
            }
            znach = 0;
            for (int i = 0; i < newText.Length - 2; i++)
            {
                if (newText[znach] != "")
                {
                    copy = Poisk(newText, znach, out copy);
                }
                newText = copy;

                znach++;
            }
            for (int i = 0; i < newText.Length-1; i++)
            {
                Console.WriteLine(newText[i]);
            }

            




            Console.ReadKey();
        }
    }
}
