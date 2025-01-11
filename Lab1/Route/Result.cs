namespace Itmo.ObjectOrientedProgramming.Lab1.Route;

public class Result
{
    public int Time { get; }

    public bool Success { get; }

    public Result(int time, bool success)
    {
        Time = time;
        Success = success;
    }
}
