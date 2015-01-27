using System.IO;
using System;

class Program
{
    public class A{
        
        public A()
        {
            Console.WriteLine("Cunstructor in A");
        }
         public virtual void display()
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
           public override void display()
        {
            Console.WriteLine("display in B");
        }
    }
    
    public class C:B
    {
        public C()
        {
        Console.WriteLine("Cunstructor in C");
        }
           public sealed override void display()
        {
            Console.WriteLine("display in C");
        }
    }
    
    public class D:C
    {
        public D()
        {
        Console.WriteLine("Cunstructor in D");
        }
           public new void display()
        {
            Console.WriteLine("display in D");
        }
    }
    
    static void Main()
    {
        //Console.WriteLine("Hello, World!");
        A obja=new A();
        B objb=new B();
        C objc=new C();
        D objd=new D();
        
        obja.display();
        objb.display();
         objc.display();
        objd.display();
        
        A objm=(A)objb;
        //B objmm=new A();//it gives error
       objm.display();
        
       
        B objmm=(B)objc;
        objmm.display();
        
        C objcmm=(C)objd;
        objcmm.display();//sealed function or class can not be inherited, either by using override .
    }
}
/** note:private cunstructor can not be inherited**/
/*output:
Cunstructor in A
Cunstructor in A
Cunstructor in B
Cunstructor in A
Cunstructor in B
Cunstructor in C
Cunstructor in A
Cunstructor in B
Cunstructor in C
Cunstructor in D
display in A
display in B
display in C
display in D
display in B
display in C
display in C*/ 
