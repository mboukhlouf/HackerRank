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
     * Complete the 'whatFlavors' function below.
     *
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY cost
     *  2. INTEGER money
     */

    public static void whatFlavors(List<int> cost, int money)
    {
        var hashTable = new Dictionary<int, int>(cost.Count);
        for(int i = 0; i < cost.Count; i++)
        {
            if(hashTable.ContainsKey(cost[i]))
            {
               continue; 
            }
            hashTable.Add(cost[i], i);
        }
        
        for(int i = 0; i < cost.Count; i++)
        {
            var ci = cost[i];
            var cj = money - ci;
            if(hashTable.ContainsKey(cj))
            {
                var j = hashTable[cj];
                if(i == j)
                {
                    continue;
                }
                if(j > i)
                {
                    Console.WriteLine($"{i + 1} {j + 1}");
                }
                else
                {
                    Console.WriteLine($"{j + 1} {i + 1}");
                }
                return;
            }
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int money = Convert.ToInt32(Console.ReadLine().Trim());
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> cost = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(costTemp => Convert.ToInt32(costTemp)).ToList();
            Result.whatFlavors(cost, money);
        }
    }
}
