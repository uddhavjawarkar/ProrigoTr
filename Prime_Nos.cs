using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
    internal class Prime_Nos
    {
        static void Main(string[] args)
        {
            
            Console.Write( "Starting no: ");
            int initial=Convert.ToInt32(Console.ReadLine());
            Console.Write("Upto range: ");
            int final=Convert.ToInt32(Console.ReadLine());

            
            for (int i=initial;i<=final;i++)
            {
                int counter = 0;

                for(int j=2;j<=i/2;j++)
                {
                    if(i%j==0)
                    {
                        counter++;
                        break;
                    }
                }
                if(counter==0 && i!=1)
                    Console.WriteLine("Prime no are: "+ i);
            }

        }
    }
}
