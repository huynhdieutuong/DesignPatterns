namespace Command.Stereo;
internal class Stereo
{
    private readonly string Name;

    public Stereo(string name)
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

    public void SetCd()
    {
        Console.WriteLine($"{Name} set CD");
    }

    public void SetDvd()
    {
        Console.WriteLine($"{Name} set DVD");
    }

    public void SetRadio()
    {
        Console.WriteLine($"{Name} set radio");
    }

    public void SetVolume(int number)
    {
        Console.WriteLine($"{Name} set volume {number}");
    }
}
