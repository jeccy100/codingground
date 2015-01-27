using System.IO;
using System;

class Program
{
     private static int aa;
    public static void display()
        {
        
            Console.WriteLine(aa);
        }
    public class A
    {
       
        public int aaa;
        static A()
        {
           aa++; 
            Console.WriteLine("static cunstructor");
        }
        
        public A()
        {
            aa++;
            Console.WriteLine("default cunstructor");
        }
        
            
    }
    public static bool Palindrom(string palvalue)
    {//malayalam
      int min=0;
        int max=palvalue.Length-1;
        while(true)
        {
            if(min>max)
            {
                return true;
            }
            char a = palvalue[min];
	    char b = palvalue[max];
            if(palvalue[min]!=palvalue[max])
            {
                return false;
            }
            min++;
            max--;
            
        }
     
    // return true;
        
    }
    static void Main()
    {
        A dd=new A();
        A fg=new A();
       Program.display();
       Console.WriteLine(Palindrom("maayalam"));
       
    }
}
/* Output:
static cunstructor
default cunstructor
default cunstructor
3
False*/
