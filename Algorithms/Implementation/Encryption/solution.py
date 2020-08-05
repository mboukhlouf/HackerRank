#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the encryption function below.
def encryption(s):
    s = s.replace(" ", "")
    l = math.sqrt(len(s))
    row_count = math.floor(l)
    col_count = math.ceil(l)

    if row_count * col_count < len(s):
        row_count = row_count + 1

    grid = [['' for j in range(col_count)]for i in range(row_count)]
    i = 0
    j = 0

    for c in s:
        grid[i][j] = c
        j = j + 1
        if j == len(grid[i]):
            j = 0
            i = i + 1

    return get_columns(grid)


def get_columns(grid):
    result = ""
    for j in range(len(grid[0])):
        for i in range(len(grid)):
            result = result + grid[i][j]
        if j != len(grid[0]) - 1:
            result = result + " "
    return result

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    s = input()
    result = encryption(s)
    fptr.write(result + '\n')
    fptr.close()
