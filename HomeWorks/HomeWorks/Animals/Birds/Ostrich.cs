namespace HomeWork_9.Animals.Birds;

public class Ostrich : NotFlyingBird
{
    public Ostrich(){}
    public Ostrich(string name, string host , string feathers)
    {
        Name = name;
        Host = Host;
        Feathers = feathers;
    }
    public override void SaySomething()
    {
        Console.WriteLine($"I am ostrich {Name} and when I am scary I hide my had in the ground, my owner is {Host} my age is {Age} years");
    }
}