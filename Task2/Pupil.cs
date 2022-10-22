using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Studying...");
        }

        public virtual void Read()
        {
            Console.WriteLine("Reading...");
        }

        public virtual void Write()
        {
            Console.WriteLine("Writing...");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Relaxing...");
        }
    }
}
