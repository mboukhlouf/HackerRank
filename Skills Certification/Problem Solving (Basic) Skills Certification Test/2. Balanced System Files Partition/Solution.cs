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
    public static int mostBalancedPartition(Dictionary<int, int> parent, List<int> files_size)
    {
        Dictionary<int, IEnumerable<int>> children = parent.GroupBy(pair => pair.Value)
        .ToDictionary(group => group.Key, group => group.Select(pair => pair.Key));

        Dictionary<int, long> realFileSizes = new Dictionary<int, long>();
        calculateRealFileSizesRecursive(children, realFileSizes, files_size, 0);

        long minimumDifference = int.MaxValue;
        mostBalancedPartitionRecursive(children, realFileSizes, 0, ref minimumDifference);
        return (int)minimumDifference;
    }
    
    public static long calculateRealFileSizesRecursive(Dictionary<int, IEnumerable<int>> children, Dictionary<int, long> realFileSizes, List<int> files_size, int node) {
        long nodeFileSize = files_size[node];
        if(children.ContainsKey(node)) {
            foreach(var child in children[node]) {
                nodeFileSize += calculateRealFileSizesRecursive(children, realFileSizes, files_size, child);
            }
        }
        
        realFileSizes[node] = nodeFileSize;
        return nodeFileSize;
    }

    public static void mostBalancedPartitionRecursive(Dictionary<int, IEnumerable<int>> children, Dictionary<int, long> realFileSizes, int node, ref long minimumDifference) {
        if(children.ContainsKey(node)) {
            foreach(var child in children[node]) {
                long sizeWithoutChild = realFileSizes[0] - realFileSizes[child];
                long absDifference = Math.Abs(sizeWithoutChild - realFileSizes[child]);
                if(absDifference < minimumDifference) {
                    minimumDifference = absDifference;
                }
                mostBalancedPartitionRecursive(children, realFileSizes, child, ref minimumDifference);
            }
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int parentCount = Convert.ToInt32(Console.ReadLine().Trim());
        Dictionary<int, int> parent = new Dictionary<int, int>();
        for (int i = 0; i < parentCount; i++)
        {
            int parentItem = Convert.ToInt32(Console.ReadLine().Trim());
            parent.Add(i, parentItem);
        }
        int files_sizeCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> files_size = new List<int>();
        for (int i = 0; i < files_sizeCount; i++)
        {
            int files_sizeItem = Convert.ToInt32(Console.ReadLine().Trim());
            files_size.Add(files_sizeItem);
        }
        int result = Result.mostBalancedPartition(parent, files_size);
        Console.WriteLine(result);
    }
}
