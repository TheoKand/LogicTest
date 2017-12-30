using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTest
{
    public class Door
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

    public class Configuration
    {
        public Guard guard1;
        public Guard guard2;

        public override string ToString()
        {
            return "-First Guard " + guard1.ToString() + "\r\n" + "-Second Guard " + guard2.ToString();
        }

    }





}
