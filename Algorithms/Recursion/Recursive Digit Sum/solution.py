#!/bin/python3

import math
import os
import random
import re
import sys


# Complete the superDigit function below.
def superDigit(n, k):
    return super_digit_recursive(sum_digits(n, k))


def sum_digits(n, k):
    digits = get_digits(n)
    sum_digits = sum(digits)
    sum_digits = sum_digits * k
    return sum_digits


def get_digits(p):
    if isinstance(p, int):
        p = str(p)
    digits = []
    for d in p:
        digits.append(d)
    return list(map(int, digits))


def super_digit_recursive(p):
    digits = get_digits(p)
    if len(digits) == 1:
        return digits[0]
    else:
        sum_digits = sum(digits)
        return super_digit_recursive(sum_digits)

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    nk = input().split()
    n = nk[0]
    k = int(nk[1])
    result = superDigit(n, k)
    fptr.write(str(result) + '\n')
    fptr.close()
