public class Person
{
    public virtual void Introduce()
    {
        Console.WriteLine("i am a person");
    }
}
public class Student : Person
{
    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("i am also a student");
    }
}
class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Introduce();
    }
}