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
using System;

class Result
{

    /*
     * Complete the 'marcsCakewalk' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY calorie as parameter.
     */

    public static long marcsCakewalk(List<int> calories)
    {
        long minimumWalk = 0;
        calories.Sort();
        for(int i = calories.Count - 1; i >= 0; i--)
        {
            int j = calories.Count - 1 - i;
            minimumWalk += (long)Math.Pow(2, j) * calories[i];
        }
        return minimumWalk;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> calorie = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(calorieTemp => Convert.ToInt32(calorieTemp)).ToList();

        long result = Result.marcsCakewalk(calorie);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
