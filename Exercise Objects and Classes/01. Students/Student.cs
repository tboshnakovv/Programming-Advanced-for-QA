class Student
{
    //field -> характеристики

    private string firstname;
    private string lastname;
    private double grade;

    //properties -> осигуряват достъп до полетата

    public string FirstName
    {
        get { return firstname; }
        set { firstname = value; }
    }

    public string LastName
    {
        get { return lastname; } 
        set { lastname = value; }
    }

    public double Grade
    {
        get { return grade; }
        set { grade = value; } 
    }
    

    //constructor -> метод, чрез който създавме обекти от класа
    public Student (string firstName, string lastName, double grade)
    {
        //нов празен обект
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
        
    }
}