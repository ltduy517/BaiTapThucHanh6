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
    public new void Speak()
    {
        Console.WriteLine("Cat is meowing...");
    }
}
class Program
{
    static void Main()
    {
        Animal a1 = new Dog();
        a1.Speak();

        Dog d = new Dog();
        d.Speak();

        Animal a2 = new Cat();
        a2.Speak();

        Cat c = new Cat();
        c.Speak();
    }
}