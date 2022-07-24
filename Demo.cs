using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
     class Demo
    {
        static void Main()
        {
            int num, m;
            bool Isprime = true;
            num = int.Parse(System.Console.ReadLine());
            m = num / 2;

            for(int i=1;i<=m;i++)
            {
                if (num % i == 0)
                    Isprime = false;
                break;
            }
            if(Isprime)
            {
                System.Console.WriteLine("Prime No: " + num);
            }
            else
            {
                System.Console.WriteLine("Not Prime No: " + num);
            }
        }
    }
}
