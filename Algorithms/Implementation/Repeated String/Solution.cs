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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        long aCount = 0;
        int aCountInS = s.Count(c => c == 'a');
        aCount += aCountInS * (n / s.Length);
        int rest = (int)(n % s.Length);
        for(int i = 0; i < rest; i++) {
            if(s[i] == 'a') {
                aCount++;
            }
        }
        return aCount;
    }

    static void Main(string[] args) {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());
        long result = repeatedString(s, n);
        Console.WriteLine(result);
    }
}
