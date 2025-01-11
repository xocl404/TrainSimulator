using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.RoutePart;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;
using Xunit;

namespace Lab1.Tests;

public class Test7
{
    [Fact]
    public void CheckingForTheUsualWay()
    {
        // Arrange
        var train = new Train(1, 40, 1);
        var parts = new IRoutePart[2]
        {
            new UsualWay(16),
            new EndRoute(15),
        };

        // Act
        var s = new GoRoute();

        // Assert
        Assert.False(s.WayPassage(train, parts));
    }
}