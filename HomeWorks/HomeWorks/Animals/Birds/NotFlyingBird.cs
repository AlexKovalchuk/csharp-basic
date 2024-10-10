namespace HomeWork_9.Animals.Birds;

public abstract class NotFlyingBird : Bird
{
    public void Run()
    {
        Console.WriteLine("I cannot fly, but I believe I can run");
    }
}