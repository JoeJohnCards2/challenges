using System;

namespace AVeryBigSum
{
    class VeryBigSum
    {
        public static void Main()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            Console.WriteLine("Enter a single digit number.");
            int arCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter space-seperated values:");
            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = AVeryBigSum(ar);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();

        }

        private static long AVeryBigSum(long[] ar)
        {
            long value = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                value += ar[i];
            }

            return value;
        }
    }
}
