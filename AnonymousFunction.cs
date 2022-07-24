using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
    public delegate void mydel3(int x, int y);
     class AnonymousFunction
    {
        /* static void Add(int a, int b)
         { Console.WriteLine("Sum: "+(a+b)); }*/

        static void Main(string[] args)
        {
            mydel3 d1 = delegate (int x, int y)
              {
                  Console.WriteLine("Sum: " + (x + y));
              };
            d1(10, 20);

            //Lambda Expression

            mydel3 d2 = (x, y) =>
              {
                  Console.WriteLine("Addition: " + (x + y));
              };
        }
    }
    /*class demodd
    {
        static bool isprime(int n)
        {
            bool Isprime = true;
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n%i==0)

        }
        }
    }*/
}
