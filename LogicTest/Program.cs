using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Configuration> allConfigurations = new List<Configuration>()
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

            RunScenario(new WillYouGoThroughThisDoor(), allConfigurations);

            RunScenario(new WhatWillTheOtherOneAnswer(), allConfigurations);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private static void RunScenario(Question question,List<Configuration> scenarios)
        {
            Console.WriteLine("QUESTION:" + question.ToString());
            Console.WriteLine();

            for (int i = 0; i < scenarios.Count; i++)
            {
                Configuration scenario = scenarios[i];

                Console.WriteLine($"Scenario {i + 1}:");
                Console.WriteLine(scenario);
                Console.WriteLine();

                Console.WriteLine("Asking first guard: " + question.AskQuestion(scenario.guard1));
                Console.WriteLine("Asking second guard: " + question.AskQuestion(scenario.guard2));

                Console.WriteLine();
            }
        }

    }
}
