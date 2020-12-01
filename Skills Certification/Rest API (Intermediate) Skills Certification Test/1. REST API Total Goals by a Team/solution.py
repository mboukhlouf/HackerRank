#!/bin/python3

import math
import os
import random
import re
import sys
import requests
import json

#
# Complete the 'getTotalGoals' function below.
#
# The function is expected to return an INTEGER.
# The function accepts following parameters:
#  1. STRING team
#  2. INTEGER year
#

def getTotalGoals0(team, year, which_team):
    current_page = 1
    total_pages = -1
    total_goals = 0
    while current_page <= total_pages or total_pages == -1:
        url = f"https://jsonmock.hackerrank.com/api/football_matches?year={year}&{which_team}={team}&page={current_page}"
        response = requests.get(url)
        data = json.loads(response.text)
        current_page += 1
        if total_pages == -1:
            total_pages = int(data["total_pages"])
        for o in data["data"]:
            total_goals += int(o[f"{which_team}goals"])
    return total_goals


def getTotalGoals(team, year):
    return getTotalGoals0(team, year, "team1") + getTotalGoals0(team, year, "team2")

    
if __name__ == '__main__':
    team = input()
    year = int(input().strip())
    result = getTotalGoals(team, year)
    print(str(result) + '\n')
