using System;

namespace BigSumChallenge
{
    public class BigSum
    {
        public static void Main()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            Console.WriteLine("Enter a number between 1 and 10");
            int arCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter space-seperated values:");
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = AVeryBigSum(ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

            Console.WriteLine("The results are: ");

            Console.WriteLine(result);
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    Console.WriteLine(ar[i].ToString());
            //}
        }

        private static long AVeryBigSum(long[] ar)
        {
            long value = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                value += Convert.ToInt32(ar[i]);
            }

            return value;
        }
    }
}
