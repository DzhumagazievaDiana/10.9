using System;
class Program
{
    public static void Main(string[] args)
    {
        Coordinate AB;
        Console.WriteLine("Введите AB.x:");
        AB.x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите AB.y:");
        AB.y = double.Parse(Console.ReadLine());
        Coordinate BC;
        Console.WriteLine("Введите BC.x:");
        BC.x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите BC.y:");
        BC.y = double.Parse(Console.ReadLine());
        Coordinate AC;
        Console.WriteLine("Введите AC.x:");
        AC.x = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите AC.y:");
        AC.y = double.Parse(Console.ReadLine());
        double P = Length(AB.x, AB.y, BC.x, BC.y) + Length(AC.x, AC.y, BC.x, BC.y) + Length(AB.x, AB.y, AC.x, AC.y);
        Console.WriteLine("Периметр = {0}", P);
        Console.ReadLine();
    }

    public static double Length(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }
}
struct Coordinate
{
    public double x;
    public double y;
}