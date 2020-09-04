#!/bin/python3

import math
import os
import random
import re
import sys


# Complete the minimumLoss function below.
def minimumLoss(price):
    price_with_indexes = list(map(lambda price, i: (price, i), price, range(len(price))))
    price_with_indexes.sort(reverse=True, key=lambda price: price[0])
    first_run = True
    for i in range(len(price_with_indexes) - 1):
        price_i = price_with_indexes[i]
        price_j = price_with_indexes[i + 1]
        if price_i[1] < price_j[1]:
            loss = price_i[0] - price_j[0]
            if loss > 0:
                if first_run:
                    minimum_loss = loss
                    first_run = False
                else:
                    if loss < minimum_loss:
                        minimum_loss = loss
    return minimum_loss


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    n = int(input())
    price = list(map(int, input().rstrip().split()))
    result = minimumLoss(price)
    fptr.write(str(result) + '\n')
    fptr.close()
