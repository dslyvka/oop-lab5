using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class GoodPupil:Pupil
    {
        public override void Study()
        {
            Console.WriteLine("I am good pupil");
            Console.WriteLine("Studying...");
        }

        public override void Read()
        {
            Console.WriteLine("I am good pupil");
            Console.WriteLine("Reading...");
        }

        public override void Write()
        {
            Console.WriteLine("I am good pupil");
            Console.WriteLine("Writing...");
        }

        public override void Relax()
        {
            Console.WriteLine("I am good pupil");
            base.Relax();
        }
    }
}
