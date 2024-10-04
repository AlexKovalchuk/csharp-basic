namespace HomeWork_8;

public class Horse: Animal
{
    public Horse()
    {

    }

    public Horse(string name, string hostName)
    {
        Name = name;
        HostName = hostName;
    }

    public override void SaySomething()
    {
        Console.WriteLine($"Negh-Neigh, life is racing and jumping! My name is {Name} and my pilot is {HostName}!");
    }
}