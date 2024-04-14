using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            c c1 = new c();
            c1.accept();
            c1.accept_gen();
            c1.display();
        }
    }
    class A
    {
        public string name;
        public int roll;
        public int age;
        public char gen;
        public void accept()
        {
            Console.WriteLine("Enter name:");
            name=Console.ReadLine();

            Console.WriteLine("Enter roll:");
            roll = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());
        }
    
    }
    class b : A 
    {
        public void accept_gen()
        {
            Console.WriteLine("Enter gen:");
            gen = Convert.ToChar(Console.ReadLine());
        }
    }
    class c : b
    {
        public void display()
        {
            Console.Write("name:"+name);
            Console.WriteLine();
             Console.Write("roll:"+roll);
             Console.WriteLine();
             Console.Write("age:"+age);
             Console.WriteLine();
             Console.Write("gen:"+gen);
             Console.WriteLine();





        
        
        }
    
    }
}
