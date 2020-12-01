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

def getWinner(competition, year):
    url = f"https://jsonmock.hackerrank.com/api/football_competitions?name={competition}&year={year}"
    response = requests.get(url)
    data = json.loads(response.text)
    return data["data"][0]["winner"]

def getTotalGoals0(competition, team, year, which_team):
    current_page = 1
    total_pages = -1
    total_goals = 0
    while current_page <= total_pages or total_pages == -1:
        url = f"https://jsonmock.hackerrank.com/api/football_matches?competition={competition}&year={year}&{which_team}={team}&page={current_page}"
        response = requests.get(url)
        data = json.loads(response.text)
        current_page += 1
        if total_pages == -1:
            total_pages = int(data["total_pages"])
        for o in data["data"]:
            total_goals += int(o[f"{which_team}goals"])
    return total_goals


def getTotalGoals(competition, team, year):
    return getTotalGoals0(competition, team, year, "team1") + getTotalGoals0(competition, team, year, "team2")


def getWinnerTotalGoals(competition, year):
    winner = getWinner(competition, year)
    return getTotalGoals(competition, winner, year)

if __name__ == '__main__':
    team = input()
    year = int(input().strip())
    result = getWinnerTotalGoals(team, year)
    print(str(result))
