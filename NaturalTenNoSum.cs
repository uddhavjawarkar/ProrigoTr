using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{//Write a program to calculate the sum of first 10 natural number.
    internal class NaturalTenNoSum
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;
            num=int.Parse(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of natural no is: "+sum);
        }
    }
}
