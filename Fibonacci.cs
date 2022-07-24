using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
    internal class Fibonacci
    {
        static void Main(string[] args)
        {
            int n1, n2, n3,num;
            n1 = 0;
            n2 = 1;
            Console.Write("Enter No: ");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1+"\n"+n2);
            for(int i=2;i<=num;i++)
            {
                n3 = n1 + n2;
                Console.Write("\n"+n3+" ");
                n1 = n2;
                n2 = n3;
            }

            
        }
    }
}
