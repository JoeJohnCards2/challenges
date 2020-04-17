using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace CompareTheTriplets
{
    public class CompareTriplets
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int AlicePoints = 0;
            int BobPoints = 0;
            List<int> result = new List<int>();

            for(int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    AlicePoints += 1;
                }
                else if (a[i] < b[i])
                {
                    BobPoints += 1;
                }
                // No points given if both numers are the same
            }
            result.Add(AlicePoints);
            result.Add(BobPoints);

            return result;

        }

        public static void Main()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            Console.WriteLine("Please enter three numbers separated by a space: ");
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            Console.WriteLine("Please enter another set of three numbers separated by a space: ");
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            //textWriter.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
