using System;
using System.Collections.Generic;
using TheLiarAndTheTruthTeller.Core;

namespace TheLiarAndTheTruthTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintQuestion(new DoesThisDoorLeadToFreedom());

            PrintQuestion(new WhatWillTheOtherGuardSay());

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }

        private static void PrintQuestion(Question question)
        {
            
            Console.WriteLine("QUESTION:" + question.ToString());
            Console.WriteLine();

            for (int i = 0; i < Configuration.AllPossible.Count; i++)
            {
                Configuration configuration = Configuration.AllPossible[i];

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
