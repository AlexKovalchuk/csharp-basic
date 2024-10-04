namespace HomeWork_8;

public class Fish: Animal
{
    public Fish()
    {

    }

    public Fish(string name, string hostName)
    {
        Name = name;
        HostName = hostName;
    }

    public override void SaySomething()
    {
        Console.WriteLine($"Glub-Glub, the sea is great! My name is {Name} and my host is {HostName}!");
    }
}