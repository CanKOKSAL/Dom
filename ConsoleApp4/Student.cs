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

        do
        {
            if (Name.Length < 3 || SurName.Length < 3)
            {
                Console.WriteLine("Please write your name and surname carefully");
                Name = Console.ReadLine();               
                SurName = Console.ReadLine();
                Console.WriteLine("And write your value again");
                Score = double.Parse(Console.ReadLine());
            }

        } while (Name.Length < 3 || SurName.Length < 3);


        do
        {
            if (Score > 100 || Score < 0)
            {
                Console.WriteLine("Please write your name and surname again");
                Name = Console.ReadLine();
                SurName = Console.ReadLine();
                Console.WriteLine("And write your true value");

                Score = double.Parse(Console.ReadLine());
            }
        } while (Score > 100 || Score < 0);


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
