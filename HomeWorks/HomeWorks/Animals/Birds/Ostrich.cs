namespace HomeWorks.Animals.Birds;

public class Ostrich : NotFlyingBird
{
    public Ostrich(){}
    public Ostrich(string name, string host , string feathers)
    {
        Name = name;
        Master = Master;
        Feathers = feathers;
    }
    public override void SaySomething()
    {
        Console.WriteLine($"I am ostrich {Name} and when I am scary I hide my had in the ground, my owner is {Master} my age is {Age} years");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am ostrich {Name} I need some food, could you feed me?");
    }
}