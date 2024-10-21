namespace HomeWorks;

public class Student
{
    public Student(string name, string surname, double score)
    {
        Name = name;
        Surname = surname;
        Score = score;
    }

    public string? Name { get; set; }
    public string? Surname { get; set; }
    public double? Score { get; set; }
}

