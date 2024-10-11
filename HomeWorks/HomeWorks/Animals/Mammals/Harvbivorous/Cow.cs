namespace HomeWorks.Animals.Mammals.Harvbivorous;

public class Cow: Harvbivorous
{
    public override void SaySomething()
    {
        Console.WriteLine($"Hey-Hey, muuu. I am cow {Name}");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am a cow {Name} Do you want some milk? Than give me some grass");
    }
}