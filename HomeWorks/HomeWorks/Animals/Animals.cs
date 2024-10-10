namespace HomeWork_9.Animals;

public abstract class Animals
{
    public string? Name { get; set; }
    public string? Host { get; set; }
    public int Age { get; set; }
    public abstract void SaySomething();
}