using System.IO;
using System;

class Program
{
    public class A{
        
        public A()
        {
            Console.WriteLine("Cunstructor in A");
        }
        virtual public void display()
        {
            Console.WriteLine("display in A");
        }
    }
    public class B:A
    {
        public B()
        {
        Console.WriteLine("Cunstructor in B");
        }
          override public void display()
        {
            Console.WriteLine("display in B");
        }
    }
    static void Main()
    {
        //Console.WriteLine("Hello, World!");
        A obja=new A();
        B objb=new B();
        obja.display();
        objb.display();
        A objm=new B();
        //B objmm=new A();//it gives error
       objm.display();
    }
}
/*output:
Cunstructor in A                                                              
Cunstructor in A                                                              
Cunstructor in B                                                              
display in A                                                                  
display in B                                                                  
Cunstructor in A                                                              
Cunstructor in B                                                              
display in B*/ 