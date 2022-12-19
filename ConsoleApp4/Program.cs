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


Student student = new Student(name, Surname, score);

student.GetFullInfo();
student.CanTakeExam();



