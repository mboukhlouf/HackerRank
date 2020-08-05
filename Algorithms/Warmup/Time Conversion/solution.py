#!/bin/python3

import os
import sys
import re

#
# Complete the timeConversion function below.
#
def timeConversion(s):
    pattern = r"([0-9]{1,2}):([0-9]{1,2}):([0-9]{1,2})(AM|PM)"
    match = re.search(pattern, s)
    hh = int(match.group(1))
    mm = int(match.group(2))
    ss = int(match.group(3))
    timeDay = match.group(4)
    if timeDay == 'PM' and hh != 12:
        hh = hh + 12
    
    if timeDay == 'AM' and hh == 12:
        hh = 0
        
    return str(hh).zfill(2) + ":" + str(mm).zfill(2) + ":" + str(ss).zfill(2)

if __name__ == '__main__':
    f = open(os.environ['OUTPUT_PATH'], 'w')
    s = input()
    result = timeConversion(s)
    f.write(result + '\n')
    f.close()
