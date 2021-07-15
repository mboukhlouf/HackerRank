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

    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr) {
        int numSwaps = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            while(!inPlace(arr, arr[i]))
            {
                swap(arr, i, arr[i] - 1);
                numSwaps++;
            }
        }
        return numSwaps;
    }

    static bool inPlace(int[] arr, int num)
    {
        return arr[num - 1] == num;
    }
    
    static void swap(int[] arr, int indexA, int indexB)
    {
        var temp = arr[indexA];
        arr[indexA] = arr[indexB];
        arr[indexB] = temp;    
    }
    
    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        int res = minimumSwaps(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
