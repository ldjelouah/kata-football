namespace League.Domain;

public sealed class RankingService : IRankingService
{
    public IEnumerable<Standing> BuildTable(IEnumerable<RawMatch> matches)
    {
        // Expected steps:
        // 1) Dictionary <team, Standing>
        // 2) Update Home and Away (Played/W/D/L, GF/GA, Points)
        // 3) Sort: Points desc, GoalDifference desc, GoalsFor desc, Team asc
        // 4) Return the list

        throw new NotImplementedException();
    }
}
