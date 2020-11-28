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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        a.Sort();
        int min = a[0];
        int longest = 1;
        int maxLongest = longest;
        for(int i = 1; i < a.Count; i++) 
        {
            if(a[i] - min <= 1) 
            {
                longest++;
                if(longest > maxLongest) {
                    maxLongest = longest;
                }
            } 
            else 
            {
                if(longest > maxLongest) {
                    maxLongest = longest;
                }
                longest = 1;
                min = a[i];
            }
        }
        return maxLongest;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int result = Result.pickingNumbers(a);
        Console.WriteLine(result);
    }
}
