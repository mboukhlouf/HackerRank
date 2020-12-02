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

    // Complete the countSwaps function below.
    static void countSwaps(int[] a) {
        int n = a.Length;
        int swapsCounter = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n - 1; j++) {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1]) {
                    swap(ref a[j], ref a[j + 1]);
                    swapsCounter++;
                }
            }   
        }
        Console.WriteLine($"Array is sorted in {swapsCounter} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Length - 1]}");
    }
    
    static void swap(ref int a, ref int b) {
        int temp = a;
        a = b;
        b = temp;    
    }
    
    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        countSwaps(a);
    }
}
