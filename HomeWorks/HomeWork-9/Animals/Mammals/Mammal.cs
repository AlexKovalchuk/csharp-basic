namespace HomeWork_9.Animals.Mammals;

public abstract class Mammal : Animals
{
    public void LiveOnEarth()
    {
        Console.WriteLine("I live on the earth surface, because I am mammal");
    }

    public void Run()
    {
        Console.WriteLine("I can run-run-run, boy.");
    }
}