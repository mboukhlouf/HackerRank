#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the compareTriplets function below.
def compareTriplets(a, b):
    scoreA = 0
    scoreB = 0
    for i in range(len(a)):
        if a[i] > b[i]:
            scoreA = scoreA + 1
        elif b[i] > a[i]:
            scoreB = scoreB + 1

    return [scoreA, scoreB]


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    a = list(map(int, input().rstrip().split()))
    b = list(map(int, input().rstrip().split()))
    result = compareTriplets(a, b)
    fptr.write(' '.join(map(str, result)))
    fptr.write('\n')
    fptr.close()
