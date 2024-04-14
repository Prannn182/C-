using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{


    class program
    {
      public static void main(string[] args)
      {
          A a1 = new A();
          mydelegate m = new mydelegate(a1.addnum);
          mydelegate n = new mydelegate(a1.subnum);
          mydelegate s = new mydelegate(a1.mulnum);
          m(10);
          n(30);
          s(46);
      }
    
    }
    public delegate void mydelegate(int a);
     class A
    {
        int a, b, add, sub, mul;
        float div;
        void addnum(int a)
        {
            add = a + b;
            Console.WriteLine("add:"+add);

        }
       void subnum(int c)
       {
         sub = a - b;
       Console.WriteLine("sub"+sub);
      }
        void mul(int x)
       {
          mul=a*b;
    Console.WriteLine("mul:"+mul);

       }


    }
}
