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

    // Complete the getMinimumCost function below.
    static int getMinimumCost(int k, List<int> c) {
        c.Sort();
        int minimumCost = 0;
        int currentRound = 1;
        int currentRoundCustomersServed = 0;
        
        for(int i = c.Count - 1; i >= 0; i--)
        {
            var flowerCost = c[i];
            minimumCost += flowerCost * currentRound;
            currentRoundCustomersServed++;
            if(currentRoundCustomersServed == k)
            {
                currentRound++;
                currentRoundCustomersServed = 0;   
            }
        }
        
        return minimumCost;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        var c = Console.ReadLine().Split(' ')
                    .Select(temp => Convert.ToInt32(temp))
                    .ToList();
        int minimumCost = getMinimumCost(k, c);

        textWriter.WriteLine(minimumCost);

        textWriter.Flush();
        textWriter.Close();
    }
}
