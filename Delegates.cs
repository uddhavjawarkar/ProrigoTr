using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
    public delegate int mydel4(int a, int b);
    internal class Delegates
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            mydel4 dd = (a, b) => (a + b);
            int r= dd(12, 15);
            Console.WriteLine(r);
        }
    }
    //Func Delegate
    class demoff
    {
        static string greet()
        { return "Good Morning"; }

        static int product(int a, int b, int c)
        {
            return (a * b * c);
        }
        static bool iseven(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
            //return x % 2 == 0;
        }
        static void Main(string[] args)
        {
            Func<string> d1 = greet;
            Func<int, int, int, int> d2 = product;
            int prod = d2(2, 3, 4);
            Console.WriteLine("Multiplication: " + prod);

            Action<int, int> d3 = (a, b) => Console.WriteLine("Add=" + (a + b));
            d3(3, 5);

            /*Func<int, bool> d4 = iseven;

            bool b = d4(89);*/

            Predicate<int> d5 = iseven;
            bool result = d5(25);
            Console.WriteLine(result);
        }
    }
        //Func --use when function compulsory returns a value back
        //and can take zero or max 16 parameters
        //Action Delegate-if function return type is void and may 0 or more parameters
        //Predicate - if function return compulsory boolean value back and may take 0 or more parameters

        //Call Back Function
        internal class MyCallBack
        {
            static void display()
            {
                Console.WriteLine("Good Morning");
            }
             public static void square(int a,Action d1)
            {
                Console.WriteLine("Square : "+a*a);
                d1();
            }

            static void Main(string[] args)
            {
            square(10, () => Console.WriteLine("Happy Morning")); 
            }
        }
}



