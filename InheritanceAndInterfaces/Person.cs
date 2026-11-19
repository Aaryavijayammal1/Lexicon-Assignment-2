namespace assignments4Part1;

public abstract class Person : IPerson
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    public void Jump()
    {
        Console.WriteLine("Person is jumping");
    }

    public void Climb()
    {
        Console.WriteLine("Person is climbing");
    }

    public void Walk()
    {
        Console.WriteLine("Person is walking");
    }
}