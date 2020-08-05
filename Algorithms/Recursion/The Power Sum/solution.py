#!/bin/python3

import math
import os
import random
import re
import sys


#  Complete the powerSum function below.
def powerSum(X, N):
    combinations = []
    nth_root = X ** (1 / float(N))
    start = math.floor(nth_root)
    i = start

    while i > 0:
        power_sum_recursive(X, N, i, [], 0, combinations)
        i = i - 1

    return len(combinations)


def power_sum_recursive(X, N, num, current_combination, result_combination, combinations: list):
    new_combination = current_combination + [num]
    result_combination = result_combination + num ** N
    if result_combination == X:
        add_combination(combinations, new_combination)
        return True
    elif result_combination > X:
        return False
    else:
        nth_root = (X - result_combination) ** (1 / float(N))
        start = math.floor(nth_root)
        i = start
        while i > 0:
            if i in new_combination:
                return False
            if i not in new_combination:
                rtrn = power_sum_recursive(X, N, i, new_combination, result_combination, combinations)
                #if rtrn:
                 #   return True
            i = i - 1
        return False


def add_combination(combinations, combination):
    combination.sort()
    if combination not in combinations:
        combinations.append(combination)


def unique_combinations(combinations):
    unique = []
    for combination in combinations:
        if combination not in unique:
            unique.append(combination)
    return unique



if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    X = int(input())
    N = int(input())
    result = powerSum(X, N)
    fptr.write(str(result) + '\n')
    fptr.close()
