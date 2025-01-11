using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;

namespace Itmo.ObjectOrientedProgramming.Lab1.RoutePart;

public class ForceWay : IWay
{
    public int Distance { get; }

    private int Force { get; }

    public ForceWay(int distance, int force)
    {
        Distance = distance;
        Force = force;
    }

    public Result GoRoutePart(Train train, int time)
    {
        if (!train.ForceAction(Force))
        {
            return new Result(time, false);
        }

        train.SpeedChange();
        if (train.Speed <= 0)
        {
            return new Result(time, false);
        }

        int nowDistance = train.Speed * (time % train.Accuracy);
        if (nowDistance > Distance)
        {
            time += Distance / train.Speed;

            return new Result(time, true);
        }

        time += time % train.Accuracy;
        while (nowDistance < Distance)
        {
            if (train.Speed < 0)
            {
                return new Result(time, false);
            }

            if (nowDistance != 0)
            {
                train.SpeedChange();
            }

            nowDistance += train.Accuracy * train.Speed;
            time += train.Accuracy;
        }

        time -= (nowDistance - Distance) / train.Speed;
        train.ResetSpeedup();

        return new Result(time, true);
    }
}
