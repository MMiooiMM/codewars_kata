# https://www.codewars.com/kata/55e2adece53b4cdcb900006c

import math


def race(v1, v2, g):
    if(v1 >= v2):
        return None
    v = v2 - v1
    time = g / v * 3600
    h = 0
    m = 0
    while time - 3600 >= 0:
        time -= 3600
        h += 1
    while time - 60 >= 0:
        time -= 60
        m += 1
    return [h, m, math.floor(time)]


print(race(720, 850, 70))  # [0, 32, 18]
print(race(80, 91, 37))  # [3, 21, 49]
print(race(80, 100, 40))  # [2, 0, 0]
