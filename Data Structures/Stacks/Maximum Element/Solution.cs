using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class MyStack<T> : IEnumerable<T> {
    private readonly LinkedList<T> list;
    
    public MyStack() {
        list = new LinkedList<T>();
    }

    public int Count => list.Count;
    
    public void Push(T value) {
        list.AddLast(value);
    }

    public void Pop() {
        if(list.Count > 0) {
            list.RemoveLast();
        }
    }

    public T Top() {
        if(list.Count == 0) {
            throw new InvalidOperationException("The Stack is empty.");
        }
        return list.Last.Value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return list.GetEnumerator();
    }
}

class Solution 
{
    static void Query1(int[] query, MyStack<int> stack, MyStack<int> maximums) {
        int v = query[1];
        stack.Push(v);
        if(maximums.Count == 0 || v >= maximums.Top()) {
            maximums.Push(v);
        }
    }

    static void Query2(int[] query, MyStack<int> stack, MyStack<int> maximums) {
        int v = stack.Top();
        stack.Pop();
        if(maximums.Top() == v) {
            maximums.Pop();
        }
    }
    
    static void Query3(int[] query, MyStack<int> stack, MyStack<int> maximums) {
        Console.WriteLine(maximums.Top());
    }

    static void maximumElement(List<int[]> queries) {
        var stack = new MyStack<int>();
        var maximumsStack = new MyStack<int>();

        var queriesMap = new Dictionary<int, Action<int[], MyStack<int>, MyStack<int>>>() {
            { 1, Query1 },
            { 2, Query2 },
            { 3, Query3 }
        };

        foreach(var query in queries) {
            queriesMap[query[0]](query, stack, maximumsStack);
        }
    }

    static void Main(String[] args) {
        List<int[]> queries = new List<int[]>();
        int n = int.Parse(Console.ReadLine().Trim());
        for(int i = 0; i < n; i++) {
            queries.Add(Console.ReadLine().Trim().Split(' ').Select(temp => int.Parse(temp)).ToArray());
        }
        maximumElement(queries);
    }
}
