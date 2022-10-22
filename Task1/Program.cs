using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("I am Printer");

            HP200 hp200 = new HP200();
            hp200.Print("I am HP200");

            Console.ReadLine();
        }
    }
}
