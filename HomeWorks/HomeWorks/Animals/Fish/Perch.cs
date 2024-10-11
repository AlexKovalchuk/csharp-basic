namespace HomeWorks.Animals.Fish;

public class Perch : SurfaceFish
{
    public override void SaySomething()
    {
        Console.WriteLine($"My name is {Name}, I am perch (окунь). My age is {Age} days");
    }

    public override void Feed()
    {
        Console.WriteLine($"I am perch(окунь) {Name}. Looking for food.");
    }
}