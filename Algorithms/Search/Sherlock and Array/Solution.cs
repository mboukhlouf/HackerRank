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

    // Complete the balancedSums function below.
    static string balancedSums(List<int> arr) {
        int leftSum = 0;
        int rightSum = 0;
        int leftIndex = 0;
        int rightIndex = arr.Count - 1;
        while(true) {
            if(leftIndex == rightIndex) {
                return leftSum == rightSum ? "YES" : "NO";
            }
            else if(leftSum < rightSum) {
                leftSum += arr[leftIndex];
                leftIndex++;
            }
            else if(rightSum < leftSum) {
                rightSum += arr[rightIndex];
                rightIndex--;
            } else {
                if(arr[leftIndex] < arr[rightIndex]) {
                    leftSum += arr[leftIndex];
                    leftIndex++;
                } else {
                    rightSum += arr[rightIndex];
                    rightIndex--;
                }
            }
        }
    }

    static void Main(string[] args) {
        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++) {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            string result = balancedSums(arr);

            Console.WriteLine(result);
        }
    }
}
