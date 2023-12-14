using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prediction
{
    internal class Last5Races
    {
        public string NoPilot;

        public string Race1;
        public string Race2;
        public string Race3;
        public string Race4;
        public string Race5;

        public Last5Races(string NoPilot, string Race1, string Race2, string Race3, string Race4, string Race5)
        {
            this.NoPilot = NoPilot;
            this.Race1 = Race1;
            this.Race2 = Race2;
            this.Race3 = Race3;
            this.Race4 = Race4;
            this.Race5 = Race5;
        }

        public float AvgPosLast5Races(Last5Races a)
        {
            float pos;

            pos = int.Parse(a.Race1) + int.Parse(a.Race2) + int.Parse(a.Race3) + int.Parse(a.Race4) + int.Parse(a.Race5);

            pos = pos / 5;

            return pos;
        }
    }
}
