namespace League.Domain;

public interface IRankingService
{
    /// Tri attendu: Points desc, DG desc, GF desc, Nom asc.
    IEnumerable<Standing> BuildTable(IEnumerable<RawMatch> matches);
}
