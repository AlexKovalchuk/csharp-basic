namespace HomeWorks.Animals.Mammals.Glires;

public class Mouse: Glire
{
    public override void SaySomething()
    {
        Console.WriteLine($"My name is {Name}, I am a mouse, my Host is {Master}, my age is {Age} months");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am a mouse {Name}. Do you have any chees?");
    }
}