namespace Command.CeilingFan;
internal class CeilingFan
{
    public static readonly int HIGH = 3;
    public static readonly int MEDIUM = 2;
    public static readonly int LOW = 1;
    public static readonly int OFF = 0;
    string Location;
    int Speed;

    public CeilingFan(string location)
    {
        Location = location;
        Speed = OFF;
    }

    public void High()
    {
        Speed = HIGH;
        Console.WriteLine($"{Location} ceiling fan is High");
    }

    public void Medium()
    {
        Speed = MEDIUM;
        Console.WriteLine($"{Location} ceiling fan is Medium");
    }

    public void Low()
    {
        Speed = LOW;
        Console.WriteLine($"{Location} ceiling fan is Low");
    }

    public void Off()
    {
        Console.WriteLine($"{Location} ceiling fan is Off");
    }

    public int GetSpeed() => Speed;
}
