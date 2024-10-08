namespace HomeWork_9.Animals.Mammals.Predators;

public class Dog : DogsFamily
{
    public override void SaySomething()
    {
        Console.WriteLine($"I am a dog, bow-wow-bark-bark. I protect my master {Host}, my name is {Name}, I serve him since I was born, for {Age} years");
    }
}