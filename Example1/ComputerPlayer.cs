namespace Example1;

public class ComputerPlayer : IPlayer
{
    private Random _random = new Random();

    public Choice GetChoice()
    {
        Choice p2 = (Choice)_random.Next(0, 3);
        return p2;
    }
}