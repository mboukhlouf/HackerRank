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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        arr.Sort();
        int maxBird = arr[0];
        int maxOccurences = 1;
        int lastBird = arr[0];
        int occurrencesCounter = 1;
        for(int i = 1; i < arr.Count; i++) {
            var bird = arr[i];
            if(occurrencesCounter > maxOccurences) {
                maxOccurences = occurrencesCounter;
                maxBird = lastBird;
            }
            if(bird != lastBird) {
                occurrencesCounter = 0;
                lastBird = bird;
            }
            occurrencesCounter++;
        }
        return maxBird;
    }

    static void Main(string[] args) {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        int result = migratoryBirds(arr);
        Console.WriteLine(result);
    }
}
