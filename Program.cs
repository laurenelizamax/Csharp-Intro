using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lauren";
            int cohort = 34;
            int theBestCohort = 35;

            //reassigning variables
            name = "McGarrett";
            cohort = 35;

            string greeting = "Hello " + name + ". Welcome to Cohort " + cohort;

            // String interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            // declare boolean
            bool isTheBest = cohort == theBestCohort;

            // conditionals
            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around");
            }
            else if (name == "McGarrett")
            {
                Console.WriteLine("Well, not in the cohort. But he's the best!");
            }
            else
            {
                Console.WriteLine("You may want to rethink your decisions");
            }
            // Loops
            // For Loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"cohort {cohorts[i]}");
            }

            foreach (int c in cohorts)
            {
                Console.WriteLine($"cohort {c}");
            }

            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
                // break;
            }

            // Console.WriteLine(greeting2);
        }
    }
}