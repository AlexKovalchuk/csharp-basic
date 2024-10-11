namespace HomeWorks.Animals.Fish;

public class Whale : DeepFish
{
    public Whale(){}
    public override void SaySomething()
    {
        Console.WriteLine($"I am a Whale {Name}, I do not obey to humans, my age is {Age} years");
    }


    public override void Feed()
    {
        Console.WriteLine($"I am big boy whale {Name} Or you feed me, or I it some ship in the ocean.");
    }
}