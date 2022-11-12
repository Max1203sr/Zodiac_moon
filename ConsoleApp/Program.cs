using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter date in format DD.MM.YYYY");
        string input = Console.ReadLine();
        Moon moon = new Moon(input);
        moon.Output();
    }
}