namespace Itmo.ObjectOrientedProgramming.Lab1.Transport;

public class Train : ITransport
{
    public int Speed { get; set; }

    public int SpeedUp { get; set; } = 0;

    public int Weight { get; }

    public int MaxForce { get; }

    public int Accuracy { get; }

    public Train(int weight, int maxForce, int accuracy)
    {
        Weight = weight;
        MaxForce = maxForce;
        Accuracy = accuracy;
    }

    public bool ForceAction(int force)
    {
        if (force > MaxForce)
        {
            return false;
        }

        SpeedUp = force / Weight;
        return true;
    }

    public void ResetSpeedup()
    {
        SpeedUp = 0;
    }

    public void SpeedChange()
    {
        Speed += SpeedUp * Accuracy;
    }
}
