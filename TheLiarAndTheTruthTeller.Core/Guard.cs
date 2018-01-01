using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Core
{
    public class Guard
    {
        public bool TellsTruth { get; set; }
        public bool TellsLies
        {
            get
            {
                return !TellsTruth;
            }
        }

        public Door Door { get; set; }

        public override string ToString()
        {
            return "guards " + Door.ToString() + ", tells " + (TellsTruth ? "THE TRUTH" : "LIES");
        }
    }
}
