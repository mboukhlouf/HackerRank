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

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d) {
        int[] rotatedArray = new int[a.Length];
        d = d % a.Length;
        for(int i = 0; i < a.Length; i++) {
            int rotatedIndex = i - d;
            if(rotatedIndex < 0) {
                rotatedIndex += a.Length;
            }
            rotatedArray[rotatedIndex] = a[i];
        }
        return rotatedArray;
    }

    static void Main(string[] args) {
        string[] nd = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(nd[0]);
        int d = Convert.ToInt32(nd[1]);
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
        int[] result = rotLeft(a, d);
        Console.WriteLine(string.Join(" ", result));
    }
}
