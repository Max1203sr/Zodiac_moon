using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Moon
{
    string[] dates;
    int[] dateNums;
    int l;
    int year;
    char chars = '.';

    public Moon(string date)
    {
        dates = date.Split(chars);
        dateNums = new int[3];
        l = 1;
        year = 1971;
        dateNums[0] = int.Parse(dates[1]);
        dateNums[1] = int.Parse(dates[0]);
        dateNums[2] = int.Parse(dates[2]);
    }

    public void Output()
    {
        if (year < dateNums[2])
        {
            for (int i = year; i < dateNums[2]; i++)
            {
                l += 11;
                if (l > 30)
                {
                    l -= 30;
                }
            }
        }
        else
        {
            for (int i = year; i > dateNums[2]; i--)
            {
                l += 11;
                if (l > 30)
                {
                    l -= 30;
                }
            }
        }

        Console.WriteLine(l);
        int age = dateNums[0] + dateNums[1] + l;
        Console.WriteLine(age);
        if (age > 30)
        {
            age = age - 30;
            age += 2;
        }
        if (age > 0 && age < 7)
        {
            Console.WriteLine("rising moon, less than half");
        }
        else if (age == 7)
        {
            Console.WriteLine("rising moon, exactly half");

        }
        else if (age > 7 && age < 14)
        {
            Console.WriteLine("rising moon, more than half");

        }
        else if (age == 14)
        {
            Console.WriteLine("full moon");

        }
        else if (age > 14 && age < 22)
        {
            Console.WriteLine("deacrising moon, more than half");

        }
        else if (age == 22)
        {
            Console.WriteLine("deacrising moon, exactly half");

        }
        else if (age > 22 && age < 29)
        {
            Console.WriteLine("deacrising moon, less than half");

        }
        else if (age > 28)
        {
            Console.WriteLine("no moon");
        }
    }

}