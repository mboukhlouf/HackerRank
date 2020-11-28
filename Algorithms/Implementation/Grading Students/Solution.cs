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

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        var rounded = new List<int>();
        foreach(var grade in grades) {
            if(grade < 38) {
                rounded.Add(grade);
                continue;
            }
            var nextFive = ((grade / 5) + 1) * 5;
            if(nextFive - grade < 3) {
                rounded.Add(nextFive);
                continue;
            }
            rounded.Add(grade);
        }
        return rounded;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> grades = new List<int>();
        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }
        List<int> result = Result.gradingStudents(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}
