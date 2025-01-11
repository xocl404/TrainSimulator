using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;

namespace Itmo.ObjectOrientedProgramming.Lab1.RoutePart;

public class Station : IRoutePart
{
    private int SpeedLimit { get; }

    public Station(int speedLimit)
    {
        SpeedLimit = speedLimit;
    }

    public Result GoRoutePart(Train train, int time)
    {
        if (train.Speed > SpeedLimit)
        {
            return new Result(time, false);
        }

        return new Result(time, true);
    }
}
