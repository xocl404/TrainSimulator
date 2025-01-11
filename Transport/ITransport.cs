namespace Itmo.ObjectOrientedProgramming.Lab1.Transport;

public interface ITransport
{
    public int Weight { get; }

    public int Speed { get; set; }

    public int SpeedUp { get; set; }
}
