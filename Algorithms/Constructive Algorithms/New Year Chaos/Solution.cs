using System;

class Solution
{
    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        const int MaxBribes = 2;
        int[] swaps = new int[q.Length];

        int totalSwaps = 0;
        bool ordered = false;
        while(!ordered) {
            ordered = true;
            for(int i = 0; i < q.Length - 1; i++) {
                if(q[i] > q[i + 1]) {
                    swaps[q[i] - 1]++;
                    if(swaps[q[i] - 1] > MaxBribes) {
                        System.Console.WriteLine("Too chaotic");
                        return;
                    }

                    int temp = q[i];
                    q[i] = q[i + 1];
                    q[i + 1] = temp;
                    totalSwaps++;
                    ordered = false;
                }
            }
        }
        
        Console.WriteLine(totalSwaps);
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
            minimumBribes(q);
        }
    }
}
