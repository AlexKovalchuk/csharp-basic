namespace HomeWorks.Animals.Birds;

public class Parrot : FlyingBird
{
    public Parrot() {}
    public Parrot(string name, string host , string feathers)
    {
        Name = name;
        Master = Master;
        Feathers = feathers;
    }

    public override void SaySomething()
    {
        Console.WriteLine($"My name is {Name} and my capitan is {Master} and my feathers are {Feathers}, my age is {Age} years");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am parrot {Name}. Capitan, when will you feed me?");
    }
}