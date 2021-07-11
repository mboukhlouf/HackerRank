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

class Solution {

    // Complete the maximumToys function below.
    static int maximumToys(List<int> prices, int k) {
        prices.Sort();
        int numOfToys = 0;
        var sum = 0;
        for(int i = 0; i < prices.Count; i++)
        {
            if(sum + prices[i] > k)
            {
                break;
            }
            sum += prices[i];
            numOfToys += 1;
        }
        return numOfToys;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        var prices = Console.ReadLine().Split(' ')
                                    .Select(p => Convert.ToInt32(p))
                                    .ToList();
        int result = maximumToys(prices, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
