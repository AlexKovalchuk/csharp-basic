namespace HomeWork_9.Animals.Fish;

public class Whale : DeepFish
{
    public Whale(){}
    public override void SaySomething()
    {
        Console.WriteLine($"I am a Whale {Name}, I do not obey to humans, my age is {Age} years");
    }
}