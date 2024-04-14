using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine("Enter breadth=  ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter length=");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("area of rectangle  is: " + a * b);
        Console.WriteLine("enter radius=");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("area of circle=" + 3.14 * r * r);
    }
}