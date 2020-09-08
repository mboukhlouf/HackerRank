#!/bin/python3

import math
import os
import random
import re
import sys

# Complete the surfaceArea function below.
def surfaceArea(A):
    areas = list()

    for i in range(len(A)):
        areas.append(list())
        for j in range(len(A[i])):
            height = A[i][j]
            total_area = 1 + 1 + height * 4
            hidden_area = 0
            if i - 1 >= 0:
                neighbor_height = A[i - 1][j]
                hidden_area = hidden_area + (height if neighbor_height >= height else neighbor_height)
            
            if i + 1 < len(A):
                neighbor_height = A[i + 1][j]
                hidden_area = hidden_area + (height if neighbor_height >= height else neighbor_height)
            
            if j - 1 >= 0:
                neighbor_height = A[i][j - 1]
                hidden_area = hidden_area + (height if neighbor_height >= height else neighbor_height)

            if j + 1 < len(A[i]):
                neighbor_height = A[i][j + 1]
                hidden_area = hidden_area + (height if neighbor_height >= height else neighbor_height)
            areas[i].append(total_area - hidden_area)
    
    _3d_area = 0
    for i in range(len(areas)):
        for j in range(len(areas[i])):
            _3d_area = _3d_area + areas[i][j]
    return _3d_area

if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    HW = input().split()
    H = int(HW[0])
    W = int(HW[1])
    A = []
    for _ in range(H):
        A.append(list(map(int, input().rstrip().split())))
    result = surfaceArea(A)
    fptr.write(str(result) + '\n')
    fptr.close()
