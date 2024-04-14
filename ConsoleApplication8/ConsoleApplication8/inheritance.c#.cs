using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            t1.accept();
            t1.calculate();
            t1.display();
        }
    }
    class A
    {
        public int l, b;
        public float area;
        public void accept()
        {
            Console.WriteLine("Enter length:");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breath:");
            b = Convert.ToInt32(Console.ReadLine());

           
        }
    }
    class  B : A
    {
        public void calculate()
        {
       
            area= l * b;

            Console.Write("Area is: " + area);
            Console.WriteLine();
        
        }
    }
        class Test : B
        {
            public void display()
            {
                Console.Write("length is:" + l);
                Console.WriteLine();
                Console.Write("breath is:" + b);
                Console.WriteLine();
                Console.Write("area is:" + area);
                Console.WriteLine();
            }
        }
    }


