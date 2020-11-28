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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c) {
        const int MaxJump = 2;
        int jumpsCount = 0;
        int i = 0;
        bool noMoreJumps = false;
        while(i < c.Length && !noMoreJumps) {
            noMoreJumps = true;
            for(int j = MaxJump; j > 0; j--) {
                if(i + j < c.Length && c[i + j] == 0) {
                    jumpsCount++;
                    i = i + j;
                    noMoreJumps = false;
                    break;
                }
            }
        }
        return jumpsCount;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
        int result = jumpingOnClouds(c);
        Console.WriteLine(result);
    }
}
