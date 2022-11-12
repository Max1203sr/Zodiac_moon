using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter birth date in format DD.MM");
            string input = Console.ReadLine();
            Zodiac zodiac = new Zodiac(input);
            zodiac.Print();
        }
    }
}
