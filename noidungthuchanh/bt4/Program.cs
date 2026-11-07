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
        Animal[] animals = { new Dog(), new Cat(), new Animal() };
        foreach (Animal a in animals)
        {
            a.Speak();
        }
    }
}