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

    // Complete the cutTheSticks function below.
    static List<int> cutTheSticks(List<int> arr) {
        var result = new List<int>();
        arr.Sort();
        int i = 0;
        while(i < arr.Count) {
            result.Add(arr.Count - i);
            
            int min = arr[i];
            for(int j = 0; j < arr.Count; j++) {
                arr[j] = arr[j] - min;
                if(arr[j] == 0) {
                    i = j + 1;
                }
            }
        }
        return result;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp)).ToList();
        List<int> result = cutTheSticks(arr);
        Console.WriteLine(string.Join("\n", result));
    }
}
