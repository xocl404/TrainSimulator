using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.RoutePart;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;
using Xunit;

namespace Lab1.Tests;

public class Test8
{
    [Fact]
    public void CheckingForTheUsualWay()
    {
        // Arrange
        var train = new Train(1, 40, 1);
        var parts = new IRoutePart[3]
        {
            new ForceWay(40, 4),
            new ForceWay(40, -8),
            new EndRoute(10),
        };

        // Act
        var s = new GoRoute();

        // Assert
        Assert.False(s.WayPassage(train, parts));
    }
}