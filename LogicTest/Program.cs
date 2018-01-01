using System;
using System.Collections.Generic;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller
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

            EvaluateQuestion(new DoesThisDoorLeadToFreedom(), allConfigurations);

            EvaluateQuestion(new WhatWillTheOtherGuardSay(), allConfigurations);

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private static void EvaluateQuestion(Question question,List<Configuration> configurations)
        {
            
            Console.WriteLine("QUESTION:" + question.ToString());
            Console.WriteLine();

            for (int i = 0; i < configurations.Count; i++)
            {
                Configuration configuration = configurations[i];

                Console.WriteLine($"Configuration {i + 1}:");
                Console.WriteLine(configuration);
                Console.WriteLine();

                Console.WriteLine("Asking first guard: Answer is " + question.AskQuestion(configuration.guard1));
                Console.WriteLine("Asking second guard: Answer is " + question.AskQuestion(configuration.guard2));

                Console.WriteLine();
            }

            Console.WriteLine("-------------------------------");
        }

    }
}
