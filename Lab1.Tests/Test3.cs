using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.RoutePart;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;
using Xunit;

namespace Lab1.Tests;

public class Test3
{
    [Fact]
    public void CheckingForThePermissibleSpeedOfTheStationAndTheEnd()
    {
        // Arrange
        var train = new Train(1, 40, 1);
        var parts = new IRoutePart[4]
        {
            new ForceWay(40, 4),
            new Station(16),
            new UsualWay(16),
            new EndRoute(16),
        };

        // Act
        var s = new GoRoute();

        // Assert
        Assert.True(s.WayPassage(train, parts));
    }
}