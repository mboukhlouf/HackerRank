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
     * Complete the 'equalStacks' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY h1
     *  2. INTEGER_ARRAY h2
     *  3. INTEGER_ARRAY h3
     */

    public static int equalStacks(List<int> h1, List<int> h2, List<int> h3)
    {
        int h1Height = getHeight(h1);
        int h2Height = getHeight(h2);
        int h3Height = getHeight(h3);
        
        while(h1Height != h2Height || h2Height != h3Height)
        {
            int maxHeight = max(h1Height, h2Height, h3Height);
            if(maxHeight == h1Height)
            {
                var top = peek(h1);
                pop(h1);
                h1Height -= top;
            }
            else if(maxHeight == h2Height)
            {
                var top = peek(h2);
                pop(h2);
                h2Height -= top;
            }
            else if(maxHeight == h3Height)
            {
                var top = peek(h3);
                pop(h3);
                h3Height -= top;
            }
        }
        return h1Height;
    }

    private static int getHeight(List<int> h)
    {
        return h.Sum();
    }
    
    private static int max(int a, int b, int c)
    {
        return max(max(a, b), c);
    }
    
    private static int max(int a, int b)
    {
        return a > b ? a : b;
    }
    
    private static int peek(List<int> h)
    {
        return h[0];
    }
    
    private static void pop(List<int> h)
    {
        h.RemoveAt(0);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n1 = Convert.ToInt32(firstMultipleInput[0]);

        int n2 = Convert.ToInt32(firstMultipleInput[1]);

        int n3 = Convert.ToInt32(firstMultipleInput[2]);

        List<int> h1 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h1Temp => Convert.ToInt32(h1Temp)).ToList();

        List<int> h2 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h2Temp => Convert.ToInt32(h2Temp)).ToList();

        List<int> h3 = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(h3Temp => Convert.ToInt32(h3Temp)).ToList();

        int result = Result.equalStacks(h1, h2, h3);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
