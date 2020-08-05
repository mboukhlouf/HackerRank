#!/bin/python3

import math
import os

# Complete the findMedian function below.
def findMedian(arr):
    arr.sort()
    if len(arr) % 2 != 0:
        median = arr[math.floor(len(arr) / 2)]
    else:
        median = (arr[int(len(arr) / 2)] + arr[(int(len(arr) / 2)) + 1]) / 2
    return median


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    n = int(input())
    arr = list(map(int, input().rstrip().split()))
    result = findMedian(arr)
    fptr.write(str(result) + '\n')
    fptr.close()
