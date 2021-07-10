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
using System.Numerics; 

class Result
{

    /*
     * Complete the 'fibonacciModified' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER t1
     *  2. INTEGER t2
     *  3. INTEGER n
     */
    public static BigInteger fibonacciModified(int t1, int t2, int n)
    {
        var memory = new BigInteger[n];
        memory[0] = t1;
        memory[1] = t2;
        
        for(int i = 2; i < n; i++)
        {
            memory[i] = memory[i - 2] + BigInteger.Pow(memory[i - 1], 2); 
        }

        return memory[n - 1];
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int t1 = Convert.ToInt32(firstMultipleInput[0]);
        int t2 = Convert.ToInt32(firstMultipleInput[1]);
        int n = Convert.ToInt32(firstMultipleInput[2]);
        BigInteger result = Result.fibonacciModified(t1, t2, n);
        Console.WriteLine(result);
    }
}
