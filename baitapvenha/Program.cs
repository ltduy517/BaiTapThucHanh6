public class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        Console.WriteLine(calc.Add(5, 10));
        Console.WriteLine(calc.Add(2.5, 3.7));
        Console.WriteLine(calc.Add(1, 2, 3));

        Shape[] shapes = { new Circle(), new Rectangle(), new Triangle() };
        foreach (Shape s in shapes)
        {
            s.Draw();
        }
    }
}