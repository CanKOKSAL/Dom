Console.WriteLine("Plase write your Name and Surname");
string name = Console.ReadLine();
string Surname = Console.ReadLine();

Console.WriteLine("And your score");
int score = int.Parse(Console.ReadLine());


Student student = new Student(name, Surname, score);

student.GetFullInfo();
student.CanTakeExam();
