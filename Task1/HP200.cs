using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class HP200 : Printer
    {

        Random random = new Random();

        public override void Print(string value)
        {
                Console.ForegroundColor = (ConsoleColor)random.Next(0, 16);
                Console.WriteLine(value);

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
