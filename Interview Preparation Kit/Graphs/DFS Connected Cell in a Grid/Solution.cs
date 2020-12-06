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

    // Complete the maxRegion function below.
    static int maxRegion(int[,] grid) {
        int n = grid.GetLength(0);
        int m = grid.GetLength(1);
        var visited = new bool[n, m];
        int maximum = int.MinValue;
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < m; j++) {
                int regionSize = GetRegionSize(grid, visited, i, j);
                if(regionSize > maximum) {
                    maximum = regionSize;
                }
            }
        }
        return maximum;
    }

    static int GetRegionSize(int[,] grid, bool[,] visited, int x, int y) {
        if(grid[x, y] == 0) {
            return 0;
        }
        int n = grid.GetLength(0);
        int m = grid.GetLength(1);
        int size = 1;
        visited[x, y] = true;
        for(int i = x - 1 >= 0 ? x - 1 : x; i <= (x + 1 <= n - 1 ? x + 1 : x); i++) {
            for(int j = y - 1 >= 0 ? y - 1 : y; j <= (y + 1 <= m - 1 ? y + 1 : y); j++) {
                if(!(i == x && j == y) && !visited[i, j]) {
                    size += GetRegionSize(grid, visited, i, j);
                }
            }
        }
        return size;
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] grid = new int[n, m];

        for (int i = 0; i < n; i++) {
            var values = Array.ConvertAll(Console.ReadLine().Split(' '), gridTemp => Convert.ToInt32(gridTemp));
            for(int j = 0; j < values.Length; j++) {
                grid[i, j] = values[j];
            }
        }

        int res = maxRegion(grid);
        Console.WriteLine(res);
    }
}
