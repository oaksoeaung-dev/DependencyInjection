namespace Example4;

public class Builder : IToolUser
{
    private ITool _hammer;
    private ITool _saw;
    public void SetHammer(ITool hammer)
    {
        _hammer = hammer;
    }

    public void SetSaw(ITool saw)
    {
        _saw = saw;
    }

    public void BuildHouse(ITool hammer, ITool saw)
    {
        hammer.Use();
        saw.Use();
        Console.WriteLine("House is built.");
    }
}