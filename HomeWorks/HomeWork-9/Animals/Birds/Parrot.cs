namespace HomeWork_9.Animals.Birds;

public class Parrot : FlyingBird
{
    public Parrot() {}
    public Parrot(string name, string host , string feathers)
    {
        Name = name;
        Host = Host;
        Feathers = feathers;
    }

    public override void SaySomething()
    {
        Console.WriteLine($"My name is {Name} and my capitan is {Host} and my feathers are {Feathers}, my age is {Age} years");
    }
}