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

class Solution
{
    public static int countingValleys(int steps, string path)
    {
        int valleysCount = 0;
        int currentLevel = 0;
        foreach(var step in path) {
            if(step == 'U') {
                if(currentLevel == -1) {
                    valleysCount++;
                }
                currentLevel++;
            } else {
                currentLevel--;
            }
        }
        return valleysCount;
    }
    
    public static void Main(string[] args)
    {
        int steps = Convert.ToInt32(Console.ReadLine().Trim());
        string path = Console.ReadLine();
        int result = countingValleys(steps, path);
        Console.WriteLine(result);
    }
}
