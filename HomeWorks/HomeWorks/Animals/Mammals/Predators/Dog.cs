namespace HomeWorks.Animals.Mammals.Predators;

public class Dog : DogsFamily
{
    public override void SaySomething()
    {
        Console.WriteLine($"I am a dog, bow-wow-bark-bark. I protect my master {Master}, my name is {Name}, I serve him since I was born, for {Age} years");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am a dog {Name} Do you hungry, my lord? I can find something for us.");
    }
}