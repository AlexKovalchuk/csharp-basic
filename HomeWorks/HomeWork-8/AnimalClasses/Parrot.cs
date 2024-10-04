namespace HomeWork_8;

public class Parrot : Animal
{
    public Parrot()
    {

    }

    public Parrot(string name, string hostName)
    {
        Name = name;
        HostName = hostName;
    }

    public override void SaySomething()
    {
        Console.WriteLine($"Hello, my name is {Name} and my capitan is {HostName}!");
    }
}