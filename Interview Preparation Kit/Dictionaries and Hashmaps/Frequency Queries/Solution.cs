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

    // Complete the freqQuery function below.
    static void freqQuery(List<List<int>> queries) {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();
        Dictionary<int, int> frequenciesCounts = new Dictionary<int, int>();

        foreach(var query in queries) {
            var q = query[0];
            var operand = query[1];
            if(q == 1) {
                if(frequencies.ContainsKey(operand)) {
                    frequenciesCounts[frequencies[operand]]--;
                    frequencies[operand]++;
                } else {
                    frequencies[operand] = 1;
                }

                if(frequenciesCounts.ContainsKey(frequencies[operand])) {
                    frequenciesCounts[frequencies[operand]]++;
                } else {
                    frequenciesCounts[frequencies[operand]] = 1;
                }
            }
            else if(q == 2) 
            {
                if(frequencies.ContainsKey(operand) && frequencies[operand] > 0) {
                    frequenciesCounts[frequencies[operand]]--;
                    frequencies[operand]--;

                    if(frequenciesCounts.ContainsKey(frequencies[operand])) {
                        frequenciesCounts[frequencies[operand]]++;
                    } else {
                        frequenciesCounts[frequencies[operand]] = 1;
                    }
                }
            }
            else {
                bool found = frequenciesCounts.ContainsKey(operand) && frequenciesCounts[operand] > 0;
                Console.WriteLine(found ? "1" : "0");
            }
        }

    }

    static void Main(string[] args) {
        int q = Convert.ToInt32(Console.ReadLine().Trim());
        List<List<int>> queries = new List<List<int>>();
        for (int i = 0; i < q; i++) {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }
        freqQuery(queries);
    }
}
