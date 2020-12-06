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

    // Complete the maxMin function below.
    static int maxMin(int k, List<int> arr) {
        arr.Sort();
        int minimumUnfairness = int.MaxValue;
        for(int i = 0; i + k - 1 < arr.Count; i++) {
            int max = arr[i + k - 1];
            int min = arr[i];
            if(max - min < minimumUnfairness) {
                minimumUnfairness = max - min;
            }
        }
        return minimumUnfairness;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        var arr = new List<int>(n);
        for (int i = 0; i < n; i++) {
            int arrItem = Convert.ToInt32(Console.ReadLine());
            arr.Add(arrItem);
        }
        int result = maxMin(k, arr);
        Console.WriteLine(result);
    }
}
