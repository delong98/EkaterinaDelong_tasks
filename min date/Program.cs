using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace min_date
{
    class Program
    {
        struct Date
        {
            public int day;
            public int month;
            public int year;
        }

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Vitaly\Desktop\text5.txt");
            Console.WriteLine(text);

            string[] date = text.Split(new char[] { ';' });
            Date[] newDate = new Date[date.Length];



            for (int i = 0; i < date.Length; i++)
            {
                string[] punktOfDate = date[i].Split('.');
                newDate[i].day = Convert.ToInt32(punktOfDate[0]);
                newDate[i].month = Convert.ToInt32(punktOfDate[1]);
                newDate[i].year = Convert.ToInt32(punktOfDate[2]);

                Console.WriteLine("Дата: " + punktOfDate[0] + "." + punktOfDate[1] + "." + punktOfDate[2]);
            }

            int minYear = newDate[0].year;
            int minMonth = newDate[0].month;
            int minDay = newDate[0].day;

            for (int i = 1; i < date.Length; i++)
            {
                if (minYear > newDate[i].year)
                {
                    minYear = newDate[i].year;
                    continue;
                }
                else if ((minYear < newDate[i].year))
                {
                    Console.WriteLine("Минимальная дата: " + minYear + "." + newDate[i-1].month + "." + newDate[i+1].day);
                }
                
                else
                {
                    
                        if (minMonth > newDate[i].month)
                    {
                            minMonth = newDate[i].month;
                            continue;
                    }
                        else
                        if (minMonth < newDate[i].month)
                    {
                        Console.WriteLine("Минимальная дата: " + minYear + "." + newDate[i - 1].month + "." + newDate[i+1].day);
                    }
                        
                        else
                    {
                        if (minDay> newDate[i].day)
                        {
                            minDay = newDate[i].day;
                            continue;
                        }

                        else
                        {
                            if (minDay >= newDate[i].day)
                            {
                                Console.WriteLine("Минимальная дата: " + minYear + "." + newDate[i - 1].month + "." + newDate[i+1].day);
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

