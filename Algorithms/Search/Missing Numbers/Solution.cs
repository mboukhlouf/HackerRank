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

    // Complete the missingNumbers function below.
    static List<int> missingNumbers(List<int> arr, List<int> brr) {
        var missingNumbers = new List<int>();
        int i = 0;
        int j = 0;
        arr.Sort();
        brr.Sort();
        while(j < brr.Count) {
            if(i < arr.Count && arr[i] == brr[j]) {
                i++;
            } else {
                if(!missingNumbers.Contains(brr[j])) {
                    missingNumbers.Add(brr[j]);
                }
            }
            j++;   
        }
        return missingNumbers;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> arr = Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
        int m = Convert.ToInt32(Console.ReadLine());
        List<int> brr = Console.ReadLine().Split(' ').Select(temp => Convert.ToInt32(temp)).ToList();
        List<int> result = missingNumbers(arr, brr);
        Console.WriteLine(string.Join(" ", result));
    }
}
