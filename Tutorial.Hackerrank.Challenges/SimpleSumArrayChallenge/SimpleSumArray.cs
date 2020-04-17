using System;

namespace SimpleSumArrayChallenge
{

    public class SimpleSumArray
    {
        public static void Main()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            //int arCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welcome to Simple Sum Array. \n" +
                "The numbers you enter will be sumed. \n" +
                "Make sure to seperate the numbers with a space. \n");

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);

            Console.WriteLine($"Completed with value of: {result}");
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }

        private static int simpleArraySum(int[] ar)
        {
            int result = 0;
            for( int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }
            return result;
        }
    }

}
