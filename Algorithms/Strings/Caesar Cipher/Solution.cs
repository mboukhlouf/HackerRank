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
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        var outputBuilder = new StringBuilder();
        foreach(var c in s.ToCharArray())
        {
            outputBuilder.Append(Rotate(c, k));   
        }
        return outputBuilder.ToString();
    }

    private static char Rotate(char c, int k)
    {
        var alphabetCount = 'z' - 'a' + 1;
        k = k % alphabetCount;
        char result;
        if(Char.IsLower(c))
        {
            result = (char)(c + k);
            result = (char)(((result - 'a') % alphabetCount) + 'a');
            return result;
        }
        if(Char.IsUpper(c))
        {            
            result = (char)(c + k);
            result = (char)(((result - 'A') % alphabetCount) + 'A');
            return result;
        }
        return c;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
