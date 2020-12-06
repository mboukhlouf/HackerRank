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

class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static int[] rotateLeft(int d, int[] a)
    {
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

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstMultipleInput[0]);
        int d = Convert.ToInt32(firstMultipleInput[1]);
        int[] arr = Console.ReadLine().TrimEnd().Split(' ').Select(arrTemp => Convert.ToInt32(arrTemp)).ToArray();
        int[] result = Result.rotateLeft(d, arr);
        Console.WriteLine(String.Join(" ", result));
    }
}
