using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Core
{
    public struct Door
    {
        public bool LeadsToFreedom { get; set; }

        public bool LeadsToDeath
        {
            get
            {
                return !LeadsToFreedom;
            }
        }

        public override string ToString()
        {
            return "door that leads to " + (LeadsToFreedom ? "FREEDOM" : "DEATH");
        }
    }
}
