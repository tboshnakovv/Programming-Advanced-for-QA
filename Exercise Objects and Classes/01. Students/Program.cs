int countStudents = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int count = 1; count <= countStudents; count++)
{
    string data = Console.ReadLine();
    string[] dataParts = data.Split(" ");
    //data = "Todor Boshnakov 4.50"
    //data.Split()
    //dataParts = ["Todor", "Boshnakov", "4.50"]

    string firstName = dataParts[0]; // "Todor"
    string lastName = dataParts[1];  // "Boshnakov"
    double grade = double.Parse(dataParts[2]);    // "4.50" -> 4.50

    Student student = new Student(firstName, lastName, grade);
    students.Add(student);
}

//списък с обекти от клас Student

//1. Сортирам по оценка в descending order (намаляващ ред)
students = students.OrderByDescending(s => s.Grade).ToList();

//2. Принтирам елементи в списъка (students)
foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}