#!/bin/python3

import math
import os
import random
import re
import sys


class Car:
    def __init__(self, max_speed, unit) -> None:
        self._max_speed = max_speed
        self._unit = unit
    
    def __str__(self) -> str:
        return f"Car with the maximum speed of {self._max_speed} {self._unit}"

class Boat:
    def __init__(self, max_speed) -> None:
        self._max_speed = max_speed
    
    def __str__(self) -> str:
        return f"Boat with the maximum speed of {self._max_speed} knots"

        
if __name__ == '__main__':
    q = int(input())
    queries = []
    for _ in range(q):
        args = input().split()
        vehicle_type, params = args[0], args[1:]
        if vehicle_type == "car":
            max_speed, speed_unit = int(params[0]), params[1]
            vehicle = Car(max_speed, speed_unit)
        elif vehicle_type == "boat":
            max_speed = int(params[0])
            vehicle = Boat(max_speed)
        else:
            raise ValueError("invalid vehicle type")
        print("%s" % vehicle)
