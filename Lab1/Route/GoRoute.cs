using Itmo.ObjectOrientedProgramming.Lab1.RoutePart;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;

namespace Itmo.ObjectOrientedProgramming.Lab1.Route;

public class GoRoute
{
    private int Time { get; set; }

    public bool WayPassage(Train train, IRoutePart[] partsList)
    {
        var result = new Result(0, true);
        for (int i = 0; i < partsList.Length; ++i)
        {
            result = partsList[i].GoRoutePart(train, Time);
            if (!result.Success)
            {
                break;
            }

            Time = result.Time;
        }

        return result.Success;
    }
}
