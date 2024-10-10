namespace HomeWork_9.Animals.Mammals.Glires;

public class Mouse: Glire
{
    public override void SaySomething()
    {
        Console.WriteLine($"My name is {Name}, I am a mouse, my Host is {Host}, my age is {Age} months");
    }
}