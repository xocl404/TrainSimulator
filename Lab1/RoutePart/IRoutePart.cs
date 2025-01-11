using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;

namespace Itmo.ObjectOrientedProgramming.Lab1.RoutePart;

public interface IRoutePart
{
    public Result GoRoutePart(Train train, int time);
}
