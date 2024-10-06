namespace HomeWork_9.Animals.Fish;

public abstract class SurfaceFish : Fish
{
    public void RiverSwimming()
    {
        Console.WriteLine($"I am surface and rivers swimmer {Name}");
    }
}