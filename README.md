# Premier League Match Ranking ⚽

## Goal
Implement `RankingService.BuildTable(IEnumerable<RawMatch>)` to produce a **ranking table** of teams.

## Rules
- Points: **3** for a win, **1** for a draw, **0** for a loss  

## Input
- `List<RawMatch>` (already deserialized from `data/matches.json`)  
- Model: `RawMatch(string HomeTeam, string AwayTeam, int HomeGoals, int AwayGoals)`

## Output
- `IEnumerable<Standing>` (populate `Played/Won/Drawn/Lost`, `GoalsFor/GoalsAgainst`, `Points`, and computed `GoalDifference`)

## Constraints
- C# / **.NET 8**, all **in memory**  
- Handle **both teams** per match  
- Keep the code **simple**, readable, and with small methods

## Expectations
- Correct logic and exact sorting  
- Return an **empty list** if the input is empty

## Run
```bash
dotnet run --project League.App
```

## Unit Tests

Complete the unit tests in the League.Tests project ✅.
