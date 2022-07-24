using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
    public delegate void Mydelegate(string msg);
    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Calling classA.MethodA(): "+message);
        }
    }
    class ClassB
    {
        public static void MethodB(string message)
        { Console.WriteLine("Calling classB.MethodB(): "+message);}
    }
     class DelegateEx
    {
       public static void Main(string[] args)
        {
            Mydelegate del = ClassA.MethodA;
            del("Hello World");

            del=ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Calling Lambda Expression: "+msg);
            del("Hello World");
        }
    }

    //MultiCast Delegate
    public delegate void MyDelegate(string msg);
     public class ClassAA
    {
        public static void MethodA(string message)
        { Console.WriteLine("Calling ClassAA.MethodA() with parameter: " + message); }
    }
     public class ClassBB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Calling ClassBB.MethodB() with parameter: " + message);
        }
    }
    public class Program1
    {
        public static void Main(string[] args)
        {
            MyDelegate del1=ClassAA.MethodA;
            MyDelegate del2 = ClassBB.MethodB;

            MyDelegate del = del1 + del2;
            Console.WriteLine("After del1+del2");
            del("Hello World");

            MyDelegate del3 = (string msg) => Console.WriteLine("Lambda Expression Calling: " + msg);
            del += del3;        //Combines del1+del2+del3
            Console.WriteLine("After del1+del2+del3");
            del("Hello World");

            del = del1 - del2;
            Console.WriteLine("After del1-del2");
            del("Hello World");

            del -= del1; //removes del1
            Console.WriteLine("After del-del1");
            del("Hello World");
        }
    }
    //Func Delegate
    class Program2
    {
        static int Sum(int x,int y)
        { return x + y; }
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            int result = add(10, 20);
            Console.WriteLine(result);
        }
    }
}
