namespace assignments4Part1;


public class Athlete : IPerson
{
    public string Sport { get; set; } = string.Empty;

    public void Jump()
    {
        Console.WriteLine("Athlete is jumping");
    }

    public void Climb()
    {
        Console.WriteLine("Athlete is climbing");
    }

    public void Walk()
    {
        Console.WriteLine("Athlete is walking");
    }
}