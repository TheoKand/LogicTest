
using NUnit.Framework;
using System.Collections.Generic;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller.UnitTests
{
    [SetUpFixture]
    class Setup
    {
        public static List<Configuration> allConfigurations;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            allConfigurations = new List<Configuration>()
            {
                new Configuration()
                {
                    guard1 = new Guard() { TellsTruth = true, Door = new Door() { LeadsToFreedom = true } },
                    guard2 = new Guard() { TellsTruth = false, Door = new Door() { LeadsToFreedom = false } }
                },
                new Configuration()
                {
                    guard1 = new Guard() { TellsTruth = false, Door = new Door() { LeadsToFreedom = true } },
                    guard2 = new Guard() { TellsTruth = true, Door = new Door() { LeadsToFreedom = false } }
                },
                new Configuration()
                {
                    guard1 = new Guard() { TellsTruth = true, Door = new Door() { LeadsToFreedom = false } },
                    guard2 = new Guard() { TellsTruth = false, Door = new Door() { LeadsToFreedom = true } }
                },
                new Configuration()
                {
                    guard1 = new Guard() { TellsTruth = false, Door = new Door() { LeadsToFreedom = false } },
                    guard2 = new Guard() { TellsTruth = true, Door = new Door() { LeadsToFreedom = true } }
                }
            };
        }
    }
}
