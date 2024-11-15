namespace Example3;

public class Builder
{
    // Setter Injection
    public Hammer hammer { get; set; }
    public Saw saw { get; set; }

    public void BuildHouse()
    {
        hammer.Use();
        saw.Use();
        Console.WriteLine("House is built.");
    }
}