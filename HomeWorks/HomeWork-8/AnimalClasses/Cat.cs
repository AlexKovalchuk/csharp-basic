namespace HomeWork_8;

public class Cat: Animal
{
    public Cat()
    {

    }

    public Cat(string name, string hostName)
    {
        Name = name;
        HostName = hostName;
    }

    public override void SaySomething()
    {
        Console.WriteLine($"Myau-Myau, life is chilling! My name is {Name} and my slave is {HostName}!");
    }
}