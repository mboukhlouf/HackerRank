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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        var pairsNumber = ar.GroupBy(num => num)
        .Select(group => (group.Key, group.Count() / 2))
        .Sum(tuple => tuple.Item2);
        
        return pairsNumber;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}
