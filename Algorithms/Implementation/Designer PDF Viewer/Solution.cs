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

    // Complete the designerPdfViewer function below.
    static int designerPdfViewer(int[] h, string word) {
        int maxHeight = word.Select(c => h[(int)(c - 'a')])
            .Max();
        return word.Length * maxHeight;
    }

    static void Main(string[] args) {
        int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
        string word = Console.ReadLine();
        int result = designerPdfViewer(h, word);
        Console.WriteLine(result);
    }
}
