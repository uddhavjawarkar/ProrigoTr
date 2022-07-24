using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
     public class DemoLinkedList
    {
        static void Main(string[] args)
        {

            /*LinkedList is generic type
            node type of object
            linkedList stores data in the form of nodes
            Node->data+
            Every node has address of next element in singly linkedlist
            Doubly linkedList--node has two address one is previous element address
            & another is next element address
            Use of LinkeList is when u have frequent operation of insertion in between and deletion in between 
            LinkedList is faster than List*/

            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(100);
            l1.AddLast(200);
            l1.AddFirst(300);
            l1.AddFirst(50);

            LinkedListNode<int> n1 = l1.Find(100);
            l1.AddAfter(n1, 150);
            l1.AddBefore(n1, 90);

            foreach (int data in l1)
            {
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
       
    }
    /*class Dept
    {
        public string dname;
    }
    class Emp
    {
        string ename;
        Dept d;

        static void Main(string[] args)
        {
            Emp e=new Emp();
            e.ename = "Uddhav";

            Emp e2=new Emp();
            e2.ename = "Rupesh";


            e.d = new Dept();
            e.d.dname = "IT";
        }

    }*/
    
    class demodictionary
    {
        static void Main(string[] args)
        {

            //array hashing technique
            //keys have to be unique
            //to retieve from dictionary we pass key then

            Dictionary<string, int> dd = new Dictionary<string, int>();
            dd.Add("Ajinkya", 90);
            dd.Add("Rupesh", 90);
            dd.Add("Jyoti", 91);
            dd.Add("Ropesh", 91);

            dd["Ajinkya"] = 95;
            //Remove key
            dd.Remove("Rupesh");
            Console.WriteLine(dd.Count);
            //dd.Clear();

            Console.WriteLine(dd.ContainsKey("Om"));
            Console.WriteLine(dd.ContainsValue(90));

            List<string>keys=dd.Keys.ToList();  
            Console.WriteLine(dd["Jyoti"]);

            foreach (KeyValuePair<string, int> kv in dd)
            {
                Console.WriteLine(kv.Key+"====>"+kv.Value);
            }
           //individual/single--List,LinkedList,Stack,Queue,SortedSet,HashSet
           //Key,Value---Dictionary,SortedList                    
        }
        //Retrieval time in Best case O(1)



        class DemoHash
        {
            static void Main(string[] args)
            {

                
            }
        }
    }
}
