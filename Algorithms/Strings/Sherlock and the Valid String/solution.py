#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the isValid function below.
def isValid(s):
    frequencies = count_frequencies(s)
    if is_valid_frequencies(frequencies):
        return "YES"

    for c in frequencies:
        frequencies[c] = frequencies[c] - 1
        if is_valid_frequencies(frequencies):
            return "YES"
        frequencies[c] = frequencies[c] + 1

    return "NO"


def count_frequencies(s):
    frequencies = dict()
    s = s.lower()
    for c in s:
        if c.isalpha():
            if c not in frequencies:
                frequencies[c] = 0
            frequencies[c] = frequencies[c] + 1
    return frequencies


def is_valid_frequencies(frequencies):
    first_frequency = list(frequencies.values())[0]
    for c in frequencies:
        if frequencies[c] != 0 and frequencies[c] != first_frequency:
            return False
    return True


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    s = input()
    result = isValid(s)
    fptr.write(result + '\n')
    fptr.close()
