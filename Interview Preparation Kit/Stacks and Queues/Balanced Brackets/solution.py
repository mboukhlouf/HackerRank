#!/bin/python3

import math
import os
import random
import re
import sys

def is_balanced(s):
    stack = []
    for c in s:
        if is_opening_bracket(c):
            stack.append(c)
        elif is_closing_bracket(c):
            opposite = get_opposite_bracket(c)
            if len(stack) > 0:
                if stack[len(stack) - 1] == opposite:
                    stack.pop()
                else:
                    return "NO"
            else:
                return "NO"
    if len(stack) == 0:
        return "YES"
    return "NO"


def get_opposite_bracket(bracket):
    if bracket == '{':
        return '}'
    if bracket == '}':
        return '{'

    if bracket == '[':
        return ']'
    if bracket == ']':
        return '['

    if bracket == '(':
        return ')'
    if bracket == ')':
        return '('
    
    return ""


def is_opening_bracket(c):
    return c == '{' or c == '(' or c == '['


def is_closing_bracket(c):
    return c == '}' or c == ')' or c == ']'


if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    t = int(input())
    for t_itr in range(t):
        s = input()
        result = is_balanced(s)
        fptr.write(result + '\n')
    fptr.close()
