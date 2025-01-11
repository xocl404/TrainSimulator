using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.RoutePart;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;
using Xunit;

namespace Lab1.Tests;

public class Test6
{
    [Fact]
    public void CheckingForTrainDecelerationAndAcceleration()
    {
        // Arrange
        var train = new Train(1, 40, 1);
        var parts = new IRoutePart[9]
        {
            new ForceWay(40, 4),
            new UsualWay(16),
            new ForceWay(24, -4),
            new Station(12),
            new UsualWay(12),
            new ForceWay(40, 4),
            new UsualWay(16),
            new ForceWay(24, -4),
            new EndRoute(12),
        };

        // Act
        var s = new GoRoute();

        // Assert
        Assert.True(s.WayPassage(train, parts));
    }
}