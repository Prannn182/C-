using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication12
{
    class Program
    {
        public static void Main(string[] args)
        {
            A a1 = new A();
            a1.accept();
            a1.calculate();
            a1.display();
        }
    }
    interface area
    {
        

        void accept();
        void calculate();
        void display();
    
    }
    class A: area 
    {
        
        public int l, b;
        public float area;
    
       public void accept()
        {
            Console.WriteLine("enter length:");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth:");
            b = Convert.ToInt32(Console.ReadLine());
                
        }
       public void calculate()
        {
         area = l*b;
    Console.WriteLine("area is:"+area);
        
        
        }

      public void display()
    {

        Console.Write("length is:"+l);
        Console.Write("breadth :"+b);
        Console.Write("area :" + area);
    
    }
        }

    
    
    
}
