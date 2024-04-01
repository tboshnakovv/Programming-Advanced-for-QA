namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

public class Person
{
    //field - характеристики -> име, възраст, егн
    private string name; //private модификатор за достъп, може да се използва само в рамките на класа
    private int age;
    private string egn;

    //properties -> осигуряваме достъп до полетата извън класа

    public string Egn
    {
        get { return egn; } // get дава стойността на полето
        set { egn = value; } //set задава стойност на полето 
    }

    public int Age
    {
        get { return age;} 
        set { age = value; }
    }

    public string Name
    {
        get { return name;}
        set { name = value; }
    }
}