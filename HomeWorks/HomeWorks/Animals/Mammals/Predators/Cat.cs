namespace HomeWorks.Animals.Mammals.Predators;

public class Cat : CatsFamily
{
    public override void SaySomething()
    {
        Console.WriteLine($"grumble-мяу , my name is {Name}, my age is {Age}, my slave is {Master}");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am a cat {Name} I am to lazy to go to eat, so bring me my food here and now.");
    }
}