#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the plusMinus function below.
def plusMinus(arr):
    num_plus, num_minus, num_zeros = 0, 0, 0
    for n in arr:
        if n == 0:
            num_zeros = num_zeros + 1
        elif n > 0:
            num_plus = num_plus + 1
        else:
            num_minus = num_minus + 1
    
    print(num_plus / (num_plus + num_minus + num_zeros))
    print(num_minus / (num_plus + num_minus + num_zeros))
    print(num_zeros / (num_plus + num_minus + num_zeros))


if __name__ == '__main__':
    n = int(input())
    arr = list(map(int, input().rstrip().split()))
    plusMinus(arr)
