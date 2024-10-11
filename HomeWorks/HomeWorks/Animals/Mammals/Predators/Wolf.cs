namespace HomeWorks.Animals.Mammals.Predators;

public class Wolf : DogsFamily
{
    public override void SaySomething()
    {
        Console.WriteLine($"I am wolf, I live in a forests, may name is {Name}, I dont have a host, but I have a band {BandName}");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am a wolf {Name} Our band is looking for a food and we will eat together");
    }
}