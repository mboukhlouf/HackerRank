# 2\ Python: String Representations of Objects


Implement two vehicle classes:

<u>Car:</u>

*   The constructor for Car must take two arguments. The first of them is its maximum speed, and the second one is a string that denotes the units in which the speed is given: either "km/h" or "mph".

*   The class must be implemented to return a string based on the arguments. For example, if _car_ is an object of class Car with a maximum speed of 120, and the unit is "km/h", then printing _car_ prints the following string: "Car with the maximum speed of 120 km/h", without quotes. If the maximum speed is 94 and the unit is "mph", then printing _car _prints in the following string: "Car with the maximum speed of 94 mph", without quotes.

<u>Boat:</u>

* The constructor for Boat must take a single argument denoting its maximum speed in knots.

* The class must be implemented to return a string based on the argument. For example, if _boat_ is an object of class Boat with a maximum speed of 82, then printing _boat_ prints the following string: "Boat with the maximum speed of 82 knots", without quotes.

The implementations of the classes will be tested by a provided code stub on several input files. Each input file contains _several_ queries, and each query constructs an object of one of the classes.  It then prints the string representation of the object to the standard output.

## Constraints

* 1 ≤ the number of queries in one test file ≤ 100


## Input Format Format for Custom Testing

In the first line, there is a single integer, _q_, the number of queries.

Then, _q_ lines follow. In the _i<sup>th</sup>_ of them, there are space-separated parameters. The first of them denotes the vehicle type to be constructed, and the remaining parameters denote the values passed for the constructor of the object.


## Sample Case 0

<div class="collapsable-details">

## Sample Input

```
STDIN           Function
-----           -------
2             → number of queries, q = 2
car 151 km/h  → query parameters = ["car 151 km/h", "boat 77"]
boat 77
```

## Sample Output

```
Car with the maximum speed of 151 km/h
Boat with the maximum speed of 77 knots
```

## Explanation

There are 2 queries. In the first of them, an object of class Car with the maximum speed of 151 in km/h is constructed, and then its string representation is printed to the output. In the second query, an object of class Boat is constructed with the maximum speed of 77 knots, and then its string representation is printed to the output.


## Sample Case 1

## Sample Input

```
STDIN         Function
-----         --------
3           → number of queries, q = 2
boat 101    → query parameters = ["boat 101", "car 120 mph", "car 251 km/h"]
car 120 mph
car 251 km/h
```

## Sample Output

```
Boat with the maximum speed of 101 knots
Car with the maximum speed of 120 mph
Car with the maximum speed of 251 km/h
```

## Explanation

There are 3 queries. In the first of them, an object of class Boat with the maximum speed of 101 knots is constructed, and then its string representation is printed to the output. In the second query, an object of class Car with the maximum speed of 120 in mph is constructed, and then its string representation is printed to the output. In the third query, an object of class Car with the maximum speed of 251 in km/h is constructed, and then its string representation is printed to the output.
