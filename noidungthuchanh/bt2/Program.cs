public class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal is speaking...");
    }
}
public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog is barking...");
    }
}
public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat is meowing...");
    }
}
class Program
{
    static void Main()
    {
        Animal a1 = new Dog();
        Animal a2 = new Cat();
        a1.Speak();
        a2.Speak();
    }
}