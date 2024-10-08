namespace HomeWork_9.Animals.Mammals.Predators;

public class Cat : CatsFamily
{
    public override void SaySomething()
    {
        Console.WriteLine($"grumble-мяу , my name is {Name}, my age is {Age}, my slave is {Host}");
    }
}