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

    // Complete the pairs function below.
    static int pairs(int k, List<int> list) {
        int numPairs = 0;
        for(int i = 0; i < list.Count - 1; i++) {
            for(int j = i + 1; j < list.Count; j++) {
                if(list[i] - list[j] == k) {
                    numPairs++;
                }
                else if(list[i] - list[j] > k) {
                    break;
                }
            }
        }
        return numPairs;
    }

    static void Main(string[] args) {
        string[] nk = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nk[0]);
        int k = Convert.ToInt32(nk[1]);
        var list = Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp))
            .OrderByDescending(temp => temp)
            .ToList();
        int result = pairs(k, list);
        Console.WriteLine(result);
    }
}
