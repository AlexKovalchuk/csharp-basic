namespace HomeWork_9.Animals.Fish;

public class Perch : SurfaceFish
{
    public override void SaySomething()
    {
        Console.WriteLine($"My name is {Name}, I am perch (окунь). My age is {Age} days");
    }
}