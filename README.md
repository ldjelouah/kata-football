# Premier League Match Ranking ⚽

## Goal
Implement `RankingService.BuildTable(IEnumerable<RawMatch>)` to produce a **ranking table** of teams.

## Rules
- Points: **3** for a win, **1** for a draw, **0** for a loss  
- Sorting: **Points desc** → **Goal Difference (GD) desc** → **Goals For (GF) desc** → **Team name asc**

## Input
- `List<RawMatch>` (already deserialized from `data/matches.json`)  
- Model: `RawMatch(string HomeTeam, string AwayTeam, int HomeGoals, int AwayGoals)`

## Output
- `IEnumerable<Standing>` (populate `Played/Won/Drawn/Lost`, `GoalsFor/GoalsAgainst`, `Points`, and computed `GoalDifference`)

## Constraints
- C# / **.NET 8**, all **in memory**  
- Handle **both teams** per match  
- Use a **case-insensitive dictionary** (`StringComparer.OrdinalIgnoreCase`)  
- Keep the code **simple**, readable, and with small methods

## Expectations
- Correct logic and exact sorting  
- Clear naming  
- Return an **empty list** if the input is empty

## Run
```bash
dotnet run --project League.App
```

## Unit Tests

The provided test `RankingTests.Should_Order_By_Points_Then_GD_Then_GF` must pass ✅.

Add one extra unit test:

Create matches where two teams have the same number of points.
Verify that the ranking is sorted first by Goal Difference (GD);
if GD is equal, by Goals For (GF);
and if still tied, alphabetically by team name.