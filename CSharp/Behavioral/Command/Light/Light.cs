namespace Command.Light;
internal class Light
{
    public string Name;

    public Light(string name)
    {
        Name = name;
    }

    public void On()
    {
        Console.WriteLine($"{Name} is On");
    }

    public void Off()
    {
        Console.WriteLine($"{Name} is Off");
    }
}
