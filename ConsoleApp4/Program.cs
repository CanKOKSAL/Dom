


using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
string name = "";
string Surname = "";
double score = 0;

Console.WriteLine("Plase write your Name and Surname");
name = Console.ReadLine();
Surname = Console.ReadLine();

Console.WriteLine("And your score");
score = double.Parse(Console.ReadLine());

do
{
    if(name.Length < 3 && Surname.Length < 3)
    {
     Console.WriteLine("Please write your name carefully");
     name = Console.ReadLine();
     Surname = Console.ReadLine();
    }
   
} while (name.Length < 3 && Surname.Length < 3);


do
{
    if(score > 100 && score < 0)
    { 
     Console.WriteLine("Please write true value");
     score = double.Parse(Console.ReadLine());
    }  
} while (score > 100 && score < 0);

Student student = new Student(name, Surname, score);

student.GetFullInfo();
student.CanTakeExam();
