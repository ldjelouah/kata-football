namespace League.Domain;

public interface IRankingService
{
    /// Expected sort: Points desc, GD desc, GF desc, Name asc.
    IEnumerable<Standing> BuildTable(IEnumerable<RawMatch> matches);
}
