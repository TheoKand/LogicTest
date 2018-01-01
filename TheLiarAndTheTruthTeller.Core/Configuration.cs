using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLiarAndTheTruthTeller.Core
{

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
