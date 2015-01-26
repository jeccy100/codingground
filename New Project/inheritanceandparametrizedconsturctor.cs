using System.IO;
using System;

class Program
{
    public class A{
        
        public A()
        {
            Console.WriteLine("Cunstructor in A");
        }
        
        public A(int a)
        {
            Console.WriteLine("Parameterized cunstructor in A");
        }
        virtual public void display()
        {
            Console.WriteLine("display in A");
        }
    }
    public class B:A
    {
        public B(int a)
        {
            Console.WriteLine("Parameterized cunstructor in B");
        }
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
        A obja=new A(2);
        B objb=new B(2);
        obja.display();
        objb.display();
        A objm=new B(2);
        //B objmm=new A();//it gives error
       objm.display();
    }
}
/*output:
Parameterized cunstructor in A                                                
Cunstructor in A                                                              
Parameterized cunstructor in B                                                
display in A                                                                  
display in B                                                                  
Cunstructor in A                                                              
Parameterized cunstructor in B                                                
display in B            
*/
