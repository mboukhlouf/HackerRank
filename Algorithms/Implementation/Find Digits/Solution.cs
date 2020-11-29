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

    // Complete the findDigits function below.
    static int findDigits(int n) {
        int divisorsCount = 0;
        bool still = true;
        int tempN = n;
        int digit = 0;
        while(tempN >= 10) {
            digit = tempN % 10;
            tempN = tempN / 10;
            if(digit != 0 && n % digit == 0) {
                divisorsCount++;
            }
        }
        digit = tempN % 10;
        if(digit != 0 && n % digit == 0) {
            divisorsCount++;
        }
        return divisorsCount;
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = findDigits(n);
            Console.WriteLine(result);
        }
    }
}
