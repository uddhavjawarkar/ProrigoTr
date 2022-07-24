using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
    internal class List1
    {
        static void Main(string[] args)
        {
            //Array growable default size is --4
            //Duplicates are allowed,insertion,index base,

            List<string> l2 = new List<string>() { "A", "B", "C", "D" };

            List<string> lst = new List<string>();
            lst.Add("Om");
            lst.Add("Sham");
            lst.Add("Gana");
            lst.Add("Om");
            lst.Add("Pratyush");
            lst.Add("Om");
            //lst.AddRange(l2);
            lst.InsertRange(0,l2);

            /*lst.Remove("Om");
            lst.RemoveAt(0);
            lst.Clear();*/
            lst.Insert(4, "Golu");

            string[] str=lst.ToArray();
            int idx1 = lst.IndexOf("Ganu");//0
            int idx2 = lst.LastIndexOf("Pratyush");
            

            Console.WriteLine(lst.Contains("Golu"));//Return type is bool --True
            Console.WriteLine(idx1);
            Console.WriteLine(idx2);

            foreach (string names in lst)
                Console.WriteLine(names);
            Console.WriteLine(lst.Count);
            Console.WriteLine(lst.Capacity);
           
            Console.WriteLine("-------------Iterate Using For Loop---------------");
            for(int i=0;i<lst.Count;i++)
                Console.WriteLine(lst[i]+" ");
            

        }
    }
}
