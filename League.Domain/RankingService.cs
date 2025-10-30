using System.Collections.Concurrent;

namespace League.Domain;

public sealed class RankingService : IRankingService
{
    public IEnumerable<Standing> BuildTable(IEnumerable<RawMatch> matches)
    {
        // Étapes attendues :
        // 1) Dico <team, Standing>
        // 2) Mettre à jour Home et Away (Played/W/D/L, GF/GA, Points)
        // 3) Trier: Points desc, GoalDifference desc, GoalsFor desc, Team asc
        // 4) Retourner la liste

        var table = new ConcurrentDictionary<string, Standing>(StringComparer.OrdinalIgnoreCase);

        // Bonus: helpers Update/Upsert pour éviter la duplication.

        throw new NotImplementedException();
    }
}
