using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Employee
    {
        int employee_id;
        int age;
        char gen;
        string name;

        
        
           public void accept_info()
            {

            Console.WriteLine("Enter employee id:");
            employee_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter gender:");
            gen = Convert.ToChar(Console.ReadLine());
            
            Console.WriteLine("Enter name:");
            name=Console.ReadLine();
            }
         public void display_info()
          {
            Console.Write("Employee Name is :" +  name);
            Console.WriteLine(); 
            Console.Write("Employee id is: " +  employee_id);
            Console.WriteLine();
            Console.Write("Employee age is: " +  age);
            Console.WriteLine();
            Console.Write("Employee gen is: " +  gen);
            Console.WriteLine();
          }
          }
    class Program
    {
    public static void Main(string[] args)
        {
            Employee e1= new Employee();
            e1.accept_info();
            e1.display_info();
        }

   
}
}

    

