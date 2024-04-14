using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1= new A();
            mydelegate m = new mydelegate(a1.addnum);
            mydelegate n = new mydelegate(a1.subnum);
            mydelegate s= new mydelegate(a1.mulnum);
            m(4);
            n(6);
            s(4);
        }
    }
      public delegate void mydelegate(int a);
     class A
    {
        int a=54, b=89, add, sub, mul;
        float div;
       public void addnum(int d)
        {
            add = a + b;
            Console.WriteLine("add:"+add);

        }
      public void subnum( int y)
       {
         sub = a - b;
       Console.WriteLine("sub:"+sub);
      }
       public void mulnum(int x)
       {
          mul=a*b;
          Console.WriteLine("mul:" + mul);

       }


    }
}

