using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Model
{

    public struct Configuration
    {
        public Guard guard1;
        public Guard guard2;

        public override string ToString()
        {
            return "-First Guard " + guard1.ToString() + "\r\n" + "-Second Guard " + guard2.ToString();
        }

        /// <summary>
        /// Returns all possible configurations as per which guard is in front of which door
        /// </summary>
        public static List<Configuration> AllPossible = new List<Configuration>()
            {
                new Configuration()
                {
                    guard1 = new Guard() { IsTruthTeller = true, Door = new Door() { LeadsToFreedom = true } },
                    guard2 = new Guard() { IsTruthTeller = false, Door = new Door() { LeadsToFreedom = false } }
                },
                new Configuration()
                {
                    guard1 = new Guard() { IsTruthTeller = false, Door = new Door() { LeadsToFreedom = true } },
                    guard2 = new Guard() { IsTruthTeller = true, Door = new Door() { LeadsToFreedom = false } }
                },
                new Configuration()
                {
                    guard1 = new Guard() { IsTruthTeller = true, Door = new Door() { LeadsToFreedom = false } },
                    guard2 = new Guard() { IsTruthTeller = false, Door = new Door() { LeadsToFreedom = true } }
                },
                new Configuration()
                {
                    guard1 = new Guard() { IsTruthTeller = false, Door = new Door() { LeadsToFreedom = false } },
                    guard2 = new Guard() { IsTruthTeller = true, Door = new Door() { LeadsToFreedom = true } }
                }
            };

    }
}
