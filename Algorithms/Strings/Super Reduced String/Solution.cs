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

    // Complete the superReducedString function below.
    static string superReducedString(string s) {
        var reducedBuilder = new StringBuilder();
        bool reduced = false;
        while(!reduced) {
            int i = 0;
            reduced = true;
            while(i < s.Length - 1) {
                if(s[i] == s[i + 1]) {
                    i = i + 2;
                    reduced = false;
                } else {
                    reducedBuilder.Append(s[i]);
                    i++;
                }
            }
            if(i == s.Length - 1) {
                reducedBuilder.Append(s[i]);
            }
            s = reducedBuilder.ToString();
            reducedBuilder.Clear();
        }
        if(s.Length == 0) {
            s = "Empty String";
        }
        return s;
    }

    static void Main(string[] args) {
        string s = Console.ReadLine();
        string result = superReducedString(s);
        Console.WriteLine(result);
    }
}
