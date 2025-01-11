using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.RoutePart;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;
using Xunit;

namespace Lab1.Tests;

public class Test5
{
    [Fact]
    public void CheckingForThePermissibleSpeedOfTheStationButIncreasedSpeedOfTheEnd()
    {
        // Arrange
        var train = new Train(1, 40, 1);
        var parts = new IRoutePart[5]
        {
            new ForceWay(40, 4),
            new UsualWay(16),
            new Station(16),
            new UsualWay(16),
            new EndRoute(15),
        };

        // Act
        var s = new GoRoute();

        // Assert
        Assert.False(s.WayPassage(train, parts));
    }
}