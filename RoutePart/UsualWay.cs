using Itmo.ObjectOrientedProgramming.Lab1.Route;
using Itmo.ObjectOrientedProgramming.Lab1.Transport;

namespace Itmo.ObjectOrientedProgramming.Lab1.RoutePart;

public class UsualWay : IWay
{
    public int Distance { get; }

    public UsualWay(int distance)
    {
        Distance = distance;
    }

    public Result GoRoutePart(Train train, int time)
    {
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

        while (nowDistance <= Distance)
        {
            nowDistance += train.Accuracy * train.Speed;
            time += train.Accuracy;
        }

        time -= (nowDistance - Distance) / train.Speed;

        return new Result(time, true);
    }
}
