# 1. REST API: Total Goals by a Team

In this challenge, the REST API contains information about football matches. The provided API allows querying matches by teams and year. Your task is to get the total number of goals scored by a given team in a given year.

To access a collection of matches, perform GET requests to

https://jsonmock.hackerrank.com/api/football_matches?year=<year>&team1=<team>&page=<page>

https://jsonmock.hackerrank.com/api/football_matches?year=<year>&team2=<team>&page=<page>

where <year> is the year of the competition, <team> is the name of the team, and <page> is the page of the results to request. The results might be divided into several pages. Pages are numbered from 1.

Notice that the above two URLs are different. The first URL specifies the team1 parameter (denoting the home team) while the second URL specifies the team2 parameter (denoting the visiting team). Thus, in order to get all matches that a particular team played in, you need to retrieve matches where the team was the home team and the visiting team.

For example, a GET request to

https://jsonmock.hackerrank.com/api/football_matches?year=2011&team1=Barcelona&page=2

returns data associated with matches in the year 2011, where team1 (the home team) was Barcelona, on the second page of the results.

Similarly, a GET request to

https://jsonmock.hackerrank.com/api/football_matches?year=2011&team2=Barcelona&page=1

returns data associated with matches in the year 2011 where team2 (the visiting team) was Barcelona, on the first page of the results.

The response to such a request is a JSON with the following 5 fields:

*   page: The current page of the results.

*   per_page: The maximum number of matches returned per page.

*   total: The total number of matches on all pages of the results.

*   total_pages: The total number of pages with results.

*   data: An array of objects containing matches information on the requested page.

Each match record has several fields, but in this task only the following 4 are relevant:

* team1: a string denoting the name of the first team in the match

* team2: a string denoting the name of the second team in the match

* team1goals: a string denoting the number of goals scored by team1 in the match

* team2goals: a string denoting the number of goals scored by team2 in the match

## Function Description

Complete the function _getTotalGoals_ in the editor below.

getTotalGoals has the following parameters:

    string _team:_ the name of the team

    int _year_: the year of the competition

The function must return an integer denoting the total number of goals scored by the given team in all matches in the given year that the team played in.

Input Format For Custom Testing

In the first line, there is a string, _team_.

In the second line, there is an integer, _year_.

## Sample Input For Custom Testing
```
Barcelona
2011
```

## Sample Output
```
35
```

## Explanation

The team is Barcelona and the year is 2011\. When we fetch all the matches that Barcelona played in the year 2011, we find that they scored a total of 35 goals, which is the required answer.
