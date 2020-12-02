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

    // Complete the hourglassSum function below.
    static int hourglassSumMax(int[][] arr) {
        int n = arr.Length;
        int hourglassMax = int.MinValue;
        for(int i = 1; i <= n - 2; i++) {
            for(int j = 1; j <= n - 2; j++) {
                int hourglass = hourglassSum(arr, i, j);
                if(hourglass > hourglassMax) {
                    hourglassMax = hourglass;
                }
            }
        }
        return hourglassMax;
    }
    
    static int hourglassSum(int[][] arr, int x, int y) {
        int sum = 0;
        for(int i = x - 1; i <= x + 1; i++) {
            for(int j = y - 1; j <= y + 1; j++) {
                if(i != x || j == y) {
                    sum += arr[i][j];
                }
            }
        }
        return sum;
    }
    
    static void Main(string[] args) {
        int[][] arr = new int[6][];
        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        int result = hourglassSumMax(arr);
        Console.WriteLine(result);
    }
}
