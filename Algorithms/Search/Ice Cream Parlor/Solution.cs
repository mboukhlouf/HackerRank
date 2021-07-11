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
     * Complete the 'icecreamParlor' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER m
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> icecreamParlor(int m, List<int> arr)
    {
        var hashTable = new Dictionary<int, int>(arr.Count);
        for(int i = 0; i < arr.Count; i++)
        {
            if(hashTable.ContainsKey(arr[i]))
            {
               continue; 
            }
            hashTable.Add(arr[i], i);
        }
        
        for(int i = 0; i < arr.Count; i++)
        {
            var ci = arr[i];
            var cj = m - ci;
            if(hashTable.ContainsKey(cj))
            {
                var j = hashTable[cj];
                if(i == j)
                {
                    continue;
                }
                var result = new List<int>
                {
                    i + 1, j + 1
                };
                result.Sort();
                return result;
            }
        }
        return null;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());
        for (int tItr = 0; tItr < t; tItr++)
        {
            int m = Convert.ToInt32(Console.ReadLine().Trim());

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.icecreamParlor(m, arr);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
