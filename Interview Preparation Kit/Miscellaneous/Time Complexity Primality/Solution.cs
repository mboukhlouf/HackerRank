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
     * Complete the 'primality' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts INTEGER n as parameter.
     */

    public static string primality(int n)
    {
        if(n == 1)
        {
            return "Not prime";
        }
        var root = Math.Sqrt(n);
        for(int i = 2; i <= root; i++)
        {
            if(n != i && n % i == 0)
            {
                return "Not prime";
            }
        }
        return "Prime";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        for (int pItr = 0; pItr < p; pItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string result = Result.primality(n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
