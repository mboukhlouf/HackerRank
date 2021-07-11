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
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        var digits = new List<bool>();
        while(n > 0)
        {
            var mod = n % 2;
            digits.Add(mod == 0);
            n = n / 2;
        }
        while(digits.Count < 32)
        {
            digits.Add(true);
        }
        return binaryToDecimal(digits);
    }
    
    private static long binaryToDecimal(List<bool> digits)
    {
        long result = 0;
        for(int i = 0; i < digits.Count; i++)
        {
            result += (digits[i] ? 1 : 0) * (long)Math.Pow(2, i);
        }
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
