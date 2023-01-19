using System;

namespace JDMestanzaMission2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            int[] RollCounts = new int[13]; // array to keep track of roll totals
            int rollCounter;
            double total;

            Console.Write("Enter the number of times to roll the dice: ");
            rollCounter = int.Parse(Console.ReadLine());

            Random rand = new Random();

            for (int i = 0; i < rollCounter; i++)
            {
                // generate random numbers for the dice
                int roll1 = rand.Next(1, 7); 
                int roll2 = rand.Next(1, 7);
                int rollTotal = roll1 + roll2; 
                // increment the rolls
                RollCounts[rollTotal]++; 
            }

            // print histogram
            Console.WriteLine("Histogram of Dice Rolls:");
            total = rollCounter;
            for (int i = 2; i <= 12; i++)
            {
                // calculate the percentage of rolls for each combination
                double RollPercentage = (RollCounts[i] / total) * 100; 
                Console.Write(i + ": ");
                for (int j = 0; j < RollPercentage; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
            Console.WriteLine("Thank you for playing!");
        }
    }
}
