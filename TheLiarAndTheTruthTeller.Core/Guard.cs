using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Core
{
    public struct Guard
    {
        public bool IsTruthTeller { get; set; }
        public bool IsLiar
        {
            get
            {
                return !IsTruthTeller;
            }
        }

        public Door Door { get; set; }

        public override string ToString()
        {
            return "guards " + Door.ToString() + ", tells " + (IsTruthTeller ? "THE TRUTH" : "LIES");
        }
    }
}
