using SimpleSumArrayChallenge;
using CompareTheTriplets;
using BigSumChallenge;
using System;

namespace Tutorial.Hackerrank.Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int varProgram = 0;

            Console.WriteLine("Please enter the number of the program you'd like to run. \n" +
                "1. Simple Sum Array \n" +
                "2. Compare The Triplets \n"+
                "3. A Very Big Sum \n"+
                "4. Exit \n");
            
            // varProgram stores the choice of the user.
            varProgram = Int32.Parse(Console.ReadLine());
            
            switch(varProgram)
            {
                case 1:
                    SimpleSumArray.Main();
                    break;
                case 2:
                    CompareTriplets.Main();
                    break;
                case 3:
                    BigSum.Main();
                    break;
                case 4:
                    Console.WriteLine("Have a nice day!");
                    break;
                default:
                    Console.WriteLine("You didn't enter a valid number.");
                    break;

            }
            
            
            Console.ReadLine();
        }
    }
}
