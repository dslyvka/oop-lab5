using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ClassRoom
    {
        private List<Pupil> pupils = new List<Pupil>();

        public ClassRoom(Pupil pupil1, Pupil pupil2 )
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
        }

        public void ShowPupils()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
    }
}
