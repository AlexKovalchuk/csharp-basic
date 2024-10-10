namespace HomeWork_9.Animals.Mammals.Predators;

public class Wolf : DogsFamily
{
    public override void SaySomething()
    {
        Console.WriteLine($"I am wolf, I live in a forests, may name is {Name}, I dont have a host, but I have a band {BandName}");
    }
}