#!/bin/python3

import math
import os
import random
import re
import sys


# Complete the timeInWords function below.
def timeInWords(h, m):
    ones = {
        1: "one",
        2: "two",
        3: "three",
        4: "four", 
        5: "five", 
        6: "six",
        7: "seven",
        8: "eight",
        9: "nine",
        10: "ten",
        11: "eleven",
        12: "twelve", 
        13: "thirteen", 
        14: "fourteen", 
        15: "fifteen",
        16: "sixteen",
        17: "seventeen", 
        18: "eighteen",
        19: "nineteen"
    }

    if m == 0:
        return f"{ones[h]} o' clock"
    elif m >= 1 and m <= 30:
        second_part = f"past {ones[h]}"
    else:
        m = 60 - m
        second_part = f"to {ones[h + 1]}"
    
    if m == 15:
        first_part = "quarter"
    elif m == 30:
        first_part = "half"
    elif m == 1:
        first_part = "one minute"
    elif m < 20:
        first_part = f"{ones[m]} minutes"
    elif m == 20:
        first_part = "twenty minutes"
    else:
        first_part = f"twenty {ones[m - 20]} minutes"

    return f"{first_part} {second_part}"


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    h = int(input())
    m = int(input())
    result = timeInWords(h, m)
    fptr.write(result + '\n')
    fptr.close()
