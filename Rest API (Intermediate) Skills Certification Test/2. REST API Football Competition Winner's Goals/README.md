# 2. REST API: Football Competition Winner's Goals

In this challenge, the REST API contains information about football competitions and matches. The provided API allows querying competitions by name and year, and it also allows querying matches by competition and year. The task, for a given competition name and year, is to get the total number of goals scored by the team who won the competition.

To access a competition, perform an HTTP GET request to

https://jsonmock.hackerrank.com/api/football_competitions?name=<name>&year=<year>

where <name> is the name of the competition and <year> is the year of the competition.

For example, a GET request to

https://jsonmock.hackerrank.com/api/football_competitions?name=English Premier League&year=2014

returns data associated with the English Premier League in the year 2014.

The response to such a request is a JSON object that contains the property `data`, which is an array of competitions. In this case, the array will contain only a single item. The item has the following 5 fields:

* name: a string denoting the name of the competition

* country: a string denoting the name of the country of the competition

* year: an integer denoting the year of the competition

* winner: a string denoting the team that won the competition

* runnerup: a string denoting the team that was the runner-up in the competition

Below is an example of such a JSON object:

    {
       "name":"English Premier League",
       "country":"England",
       "year":2014,
       "winner":"Chelsea",
       "runnerup":"Manchester City"
    }

Next, to access a collection of matches played by a given team in a given competition and year, perform GET requests to

https://jsonmock.hackerrank.com/api/football_matches?competition=<competition>&year=<year>&team1=<team>&page=<page>

https://jsonmock.hackerrank.com/api/football_matches?competition=<competition>&year=<year>&team2=<team>&page=<page>

Here, <competition> is the name of the competition, <year> is the year of the competition, <team> is the name of the team, and <page> is the page of the results to request. The results might be divided into several pages. Pages are numbered from 1.

Notice that the above two URLs are different. The first URL specifies the team1 parameter (denoting the home team) while the second URL specifies the team2 parameter (denoting the visiting team). Thus, in order to get all the matches a particular team played in, you need to retrieve matches where the team was the home team and the visiting team.

For example, a GET request to

https://jsonmock.hackerrank.com/api/football_matches?competition=UEFA%20Champions%20League&year=2011&team1=Barcelona&page=2

returns data associated with matches in the UEFA Champions League in the year 2011, where team1 (the home team) was Barcelona, on the second page of the results.

Similarly, a GET request to

https://jsonmock.hackerrank.com/api/football_matches?competition=UEFA%20Champions%20League&year=2011&team2=Barcelona&page=1

returns data associated with matches in the UEFA Champions League in the year 2011, where team2 (the visiting team) was Barcelona, on the first page of the results.

The response to such a request is a JSON with the following 5 fields:

* page: The current page of the results.

* per_page: The maximum number of matches returned per page.

* total: The total number of matches on all pages of the results.

* total_pages: The total number of pages with results.

* data: An array of objects containing matches information on the requested page

Each match record has several fields, but in this task only the following 4 are relevant:

* team1: a string denoting the name of the first team in the match

* team2: a string denoting the name of the second team in the match

* team1goals: a string denoting the number of goals scored by team1 in the match

* team2goals: a string denoting the number of goals scored by team2 in the match

## Function Description

Complete the function _getWinnerTotalGoals_ in the editor below.

getWinnerTotalGoals has the following parameters:

    string _competition:_ the name of the competition

    int _year_: the year of the competition

The function must return an integer denoting the total number of goals scored in all matches in the given competition by the team who won the competition.

In the first line, there is a string, _competition_.

In the second line, there is an integer, _year_.

## Sample Input For Custom Testing
```
UEFA Champions League
2011
```

## Sample Output
```
28
```

## Explanation

The competition is UEFA Champions League and the year is 2011\. One of the API endpoints can be used to determine that team Chelsea won this competition. Then, another endpoint can be used to find out that the total number of goals scored by Chelsea during this competition is 28, which is the required answer.
