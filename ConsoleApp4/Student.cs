using System;
using System.Xml.Linq;

class Student : Person
{
    public double Score;
    public bool IsGraduated;


    public Student(string name, string surname, double score)
    {
        Name = name;
        SurName = surname;
        Score = score;
    }

    public Student(string name, string surname, double score, bool isGraduated)
    {
        Name = name;
        SurName = surname;
        Score = score;
        IsGraduated = isGraduated;
    }
    public string GetFullName()
    {
        string fullName = $"{this.Name} {this.SurName}";

        return fullName;
    }
    public void GetFullInfo()
    {
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Surname: {this.SurName}");
        Console.WriteLine($"Score: {this.Score}");
       
        if (Score > 50.99)
        {
            this.IsGraduated = true;

            Console.WriteLine($"Congrats!");
        }
        if (Score <= 79.99 && Score >= 51)
        {
            Console.WriteLine("You are eligible to Graduated");
        }
        if (Score <= 89.99 && Score >= 80)
        {
            Console.WriteLine("You are eligible to Graduated as a Honor student");
        }
        if (Score <= 100 && Score >= 90)
        {
            Console.WriteLine("You are eligible to Graduated as a High Honor student");
        }
        if (this.IsGraduated == false)
        {
            Console.WriteLine("You are failed!");
        }
    }
    public void CanTakeExam()
    {
        if (this.Score <= 89.99 && this.Score >= 80)
        {
            Console.WriteLine("And also you can reexam for make your Score higher");
        }
    }
}
