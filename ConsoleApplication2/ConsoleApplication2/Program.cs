using System;

namespace Tutlane
{
    class operations
    {
        static void Main(string[] args)
        {
            int result;
            int x ,y;
            
            Console.WriteLine("enter two numbers");
            x = Convert.ToInt32(Console.ReadLine());

            y = Convert.ToInt32(Console.ReadLine());

            result = (x + y);
            Console.WriteLine("Addition : " + result);
            result = (x - y);
            Console.WriteLine("Subtraction : " + result);
            result = (x * y);
            Console.WriteLine("Multiplication : " + result);
            result = (x / y);
            Console.WriteLine("Division : " + result);
            
            
            Console.WriteLine("exit");
            Console.ReadLine();
        }
    }
}