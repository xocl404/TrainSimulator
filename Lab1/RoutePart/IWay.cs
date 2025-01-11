using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;

namespace Itmo.ObjectOrientedProgramming.Lab1.RoutePart;

public interface IWay : IRoutePart
{
    public int Distance { get; }

    public new Result GoRoutePart(Train train, int time);
}
