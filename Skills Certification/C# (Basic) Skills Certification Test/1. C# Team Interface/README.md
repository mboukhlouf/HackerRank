# 1. C#: Team Interface

Implement inheritance as described below.

Create a class Team that has the following:

1.  A member variable _teamName_ [string]
2.  A member variable _noOfPlayers_ [integer]
3.  A constructor function:
    1.  It takes 2 parameters and assigns them to _teamName _and _noOfPlayers _respectively.
4.  A member function _AddPlayer(count)_:
    1.  It takes an integer _count_ as a parameter and increases _noOfPlayers_ by _count_.
5.  A member function _RemovePlayer(count)_:
    1.  It takes an integer _count_ as a parameter and tries to decrease _noOfPlayers _by _count_.
    2.  If decreasing makes _noOfPlayers_ negative, then this function simply returns false.
    3.  Else, decrease _noOfPlayers_ by _count_ and return true.

Create a class Subteam that inherits from the above class Team. It has the following:

1.  A constructor function:
    1.  It takes 2 parameters, _teamName _and _noOfPlayers_, and calls the base class constructor with these parameters.
2.  A member function _ChangeTeamName(name)_:
    1.  It takes a string _name_ as a parameter and changes _teamName_ to _name_.<span style="display: none;"> </span>

Note: Declare all the members as public so that they are accessible by the stubbed code.

Your implementation of the function will be tested by a stubbed code on several input files. Each input file contains parameters for the function calls. The functions will be called with those parameters, and the result of their executions will be printed to the standard output by the stubbed code.

## Input Format For Custom Testing

The first line contains a string, _teamName_, and integer, _noOfPlayers_, denoting the team name and the initial number of players in the team, respectively.

The second line contains an integer, _count_, which is the parameter for the _AddPlayer_ function.

The third line contains an integer, _count_, which is the parameter for the _RemovePlayer_ function.

The fourth line contains a string, _name_, which is the parameter for _ChangeTeamName_ function.

## Sample Case 0

## Sample Input For Custom Testing

```
OldTeam 2
3
4
NewTeam
```

## Sample Output

```
Team OldTeam created
Current number of players in team OldTeam is 2
New number of players in team OldTeam is 5
Current number of players in team OldTeam is 5
New number of players in team OldTeam is 1
Team name of team OldTeam changed to NewTeam
```

## Explanation

First, a team is created with _teamName_ as 'OldTeam' and _noOfPlayers_ as 2\. Then, the _AddPlayer_ function is called with parameter 3, so the new _noOfPlayers_ becomes 5\. Then, the _RemovePlayer_ function is called with parameter 4, so the new _noOfPlayers_ becomes 1\. Finally, the _ChangeTeamName_ function is called with parameter 'NewTeam', which changes _teamName_ to 'NewTeam'.

## Sample Case 1

## Sample Input For Custom Testing

```
Champions 2
1
2
IPL
```

## Sample Output

```
Team Champions created
Current number of players in team Champions is 2
New number of players in team Champions is 3
Current number of players in team Champions is 3
New number of players in team Champions is 1
Team name of team Champions changed to IPL
```

## Explanation

First, a team is created with _teamName_ as 'Champions' and _noOfPlayers_ as 2\. Then, the _AddPlayer_ function is called with parameter 1, so the new _noOfPlayers_ becomes 3\. Then, the _RemovePlayer_ function is called with parameter 2, so the new _noOfPlayers_ becomes 1\. Finally, the _ChangeTeamName_ function is called with parameter 'IPL', which changes _teamName_ to 'IPL'.
