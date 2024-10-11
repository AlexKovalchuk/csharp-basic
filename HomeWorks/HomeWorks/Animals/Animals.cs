namespace HomeWorks.Animals;

public abstract class Animals
{
    public string? Name { get; set; }
    public string? Master { get; set; }
    public int Age { get; set; }
    public abstract void SaySomething();
    public abstract void Feed();
}