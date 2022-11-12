using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Zodiac
    {
        string[] dates;
        int day;
        int month;
        char chars = '.';

        public Zodiac(string date)
        {
            dates = date.Split(chars);
            day = int.Parse(dates[0]);
            month = int.Parse(dates[1]);
        }

        public void Print()
        {
            if (day > 20 && month == 3 || day < 19 && month == 4)
            {
                Console.WriteLine("Aries");

            }
            else if (month == 4 && day >= 20 || month == 5 && day < 21)
            {
                Console.WriteLine("Taurus");

            }
            else if (month == 5 && day >= 21 || month == 6 && day < 22)
            {
                Console.WriteLine("Gemini");

            }
            else if (month == 6 && day >= 23 || month == 7 && day < 22)
            {
                Console.WriteLine("Cancer");

            }
            else if (month == 7 && day >= 22 || month == 8 && day < 23)
            {
                Console.WriteLine("Leo");

            }
            else if (month == 8 && day >= 23 || month == 9 && day < 22)
            {
                Console.WriteLine("Virgo");

            }
            else if (month == 9 && day >= 22 || month == 10 && day < 24)
            {
                Console.WriteLine("Libra");

            }
            else if (month == 10 && day >= 24 || month == 11 && day < 23)
            {
                Console.WriteLine("Scorpio");

            }
            else if (month == 11 && day >= 22 || month == 12 && day < 22)
            {
                Console.WriteLine("Sagittarius");

            }
            else if (month == 12 && day >= 22 || month == 1 && day < 22)
            {
                Console.WriteLine("Capricorn");

            }
            else if (month == 1 && day >= 22 || month == 2 && day < 22)
            {
                Console.WriteLine("Aquarius");

            }
            else if (month == 2 && day >= 22 || month == 3 && day < 22)
            {
                Console.WriteLine("Pisces");

            }
        }
    }