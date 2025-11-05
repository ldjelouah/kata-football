using System.Text.Json;
using League.Domain;

var file = Path.Combine(AppContext.BaseDirectory, "data", "matches.json");
if (!File.Exists(file))
{
    Console.Error.WriteLine($"Input file not found: {file}");
    return;
}

var json = await File.ReadAllTextAsync(file);
var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var matches = JsonSerializer.Deserialize<List<RawMatch>>(json, options) ?? [];

IRankingService service = new RankingService(); // Implemented by the candidate

var table = service.BuildTable(matches).ToList();

int rank = 1;
foreach (var s in table)
{
    Console.WriteLine($"{rank++}. {s.Team}, {s.Points} {(s.Points > 1 ? "pts" : "pt")} " +
                      $"(GF {s.GoalsFor}, GA {s.GoalsAgainst}, DG {(s.GoalDifference >= 0 ? "+" : "")}{s.GoalDifference})");
}
