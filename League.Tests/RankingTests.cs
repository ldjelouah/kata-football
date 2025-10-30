using FluentAssertions;
using League.Domain;

namespace League.Tests;

public class RankingTests
{
    [Fact]
    public void Should_Order_By_Points_Then_GD_Then_GF()
    {
        var matches = new List<RawMatch>
        {
            new("Arsenal","Chelsea",2,1),
            new("Liverpool","Everton",1,1),
            new("Manchester City","Manchester United",3,0),
        };

        var table = new RankingService().BuildTable(matches).ToList();

        table.Should().ContainSingle(s => s.Team == "Manchester City" && s.Points == 3);
        table.Should().ContainSingle(s => s.Team == "Arsenal" && s.Points == 3);
        table.Should().ContainSingle(s => s.Team == "Liverpool" && s.Points == 1);
        table.Should().ContainSingle(s => s.Team == "Everton" && s.Points == 1);
        table.Should().ContainSingle(s => s.Team == "Chelsea" && s.Points == 0);
        table.Should().ContainSingle(s => s.Team == "Manchester United" && s.Points == 0);
    }
}
