using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProrigoTr
{//1.	WAP to add elements to and print content of it where Integer is used. In second List String is used.
    internal class ques1
    {
        static void Main(string[] args)
        {
            List<int> ls1 = new List<int>();
                ls1.Add(10);
            ls1.Add(20);
            ls1.Add(30);
            ls1.Add(40);
            ls1.Add(50);

            foreach(int i in ls1)
                Console.WriteLine(i);

            List<string> ls2=new List<string>();
            ls2.Add("Vikrant");
            ls2.Add("Amey");
            ls2.Add("Donald");
            ls2.Add("Maithili");

            foreach(string name in ls2)
                Console.WriteLine(name);
        }
    }
    class ques2
    {
        //2.	WAP add elements to List  0th location keep Integer, 1st location String now print each element and display contents.
        static void Main(string[] args)
        {
            //var al = new Arraylist();
            //using System.Collections;

            ArrayList arlist = new ArrayList();
            // or 
            //var arlist = new ArrayList(); // recommended 

            arlist.Add(0);
            arlist.Add("Ganesh");
            arlist.Add(2.22);
            arlist.Add(" ");
            arlist.Add(true);
            arlist.Add(null);

            foreach(var Elements in arlist)
                Console.Write(Elements+" ");
        }
    }
    class ques3
    {
        //3.	WAP to create a new List, add some colors (string) and print the collection.
        static void Main(string[] args)
        {
            List<string> color=new List<string>();
            color.Add("Green");
            color.Add("Red");
            color.Add("Blue");
            color.Add("Purple");
            color.Add("White");
            color.Add("Black");

            foreach(string colors in color)
                Console.WriteLine(colors);
        }
    }
    class ques5
    {
        //5.	WAP to replace the second element of an List with the specified element
        static void Main(string[] args)
        {
            ArrayList ls1=new ArrayList();
            ls1.Add("A");
            ls1.Add("B");
            ls1.Add("C");
            ls1.Add("D");
            ls1.Add("E");
            ls1.Add("F");
            Console.WriteLine(ls1.Count);
            Console.WriteLine("Before Replacement");
            foreach(string alpha in ls1)
                Console.WriteLine(alpha);

            Console.WriteLine("Aftre Replacement IInd Element");
            ls1.Insert(2, "G");
            Console.WriteLine(ls1.Count);
            foreach (string alpha in ls1)
                Console.WriteLine(alpha);

        }
    }
    class ques6
    {//6.	WAP to create List of Students and iterate over it.
        static void Main(string[] args)
        {
            List<string> student = new List<string>()
            { "Aditys","Rohan","Preet","Ajinkya","Rutvik","Jay"};

            foreach(string names in student)
                Console.WriteLine(names);
        }
    }
    class ques7
    {
        //7.	WAP to convert array to List.
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Convert to List");

            List<int> list = array.ToList();
            
            Console.WriteLine(string.Join(",",list));
            Console.WriteLine(list.Count);
        }
    }
    class ques8
    {
        //8.	WAP to print list in reverse order .
        //9.	WAP to sort the elements of List that contains String objects. Print List.
        static void Main(string[] args)
        {
            List<string> names=new List<string>() { "Vishal","Jessy","Rakul","Harsh","Madhavan","Ranjit","Bhagateya"};
            //names.Sort();   
            Console.WriteLine("Original List");
            foreach(string name in names)
                Console.WriteLine(name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("List in reverse order");
            names.Reverse();
            Console.WriteLine(string.Join("\n",names));

            Console.WriteLine("--------------------------\nOR Using Enumerable");

            List<string> reverse=Enumerable.Reverse(names).ToList();
            Console.WriteLine(string.Join("\n",reverse));
            Console.WriteLine("------------------------------\nWAP to sort the elements of List that contains String objects. Print List.");
            names.Sort();
            Console.WriteLine(string.Join("\n",names));
        }
    }
    class Employee:IComparable<Employee>
    {
        string name;
        string designation;
        int age;

        public override string ToString()
        {
            return "Name= "+name+", Designation= "+designation+", Age= "+age;
        }

        public int CompareTo(Employee other)
        {
            return other.age.CompareTo(this.age);
        }

        public Employee(string name, string designation, int age)
        {
            this.Name = name;
            this.Designation = designation;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Age { get => age; set => age = value; }
    }
    class ques10
    {
        //10.	WAP to create a class Employee with
        //(name, designation and age).
        //Now create and add Employee objects elements to List.
        //Sort the List by age in descending order and print List.
        static void Main(string[] args)
        {
            List<Employee> lst=new List<Employee>();
            lst.Add(new Employee("Aditya", "Manager", 45));
            lst.Add(new Employee("Satyendra", "Asst.Manager", 25));
            lst.Add(new Employee("Guru", "Developer", 24));
            lst.Add(new Employee("Jevel", "QA", 26));
            lst.Add(new Employee("Ketan", "Soft Developer", 30));
            lst.Add(new Employee("Rakul", ".Net Developer", 35));
            lst.Add(new Employee("Triveni", "QA", 37));
            lst.Add(new Employee("Uddhav", "Tester", 40));

            foreach(Employee n in lst)
            {
                if(n.Age>20)
                    Console.WriteLine(n);
            }
            Console.WriteLine("***********Sorting on Age*************");

            lst.Sort();
            lst.ForEach(obj => Console.WriteLine(obj));
        }
    }
    class ques11
    {
        //11.	WAP to add elements to a Dictionary and print content of it. Use int as Key and String as Value.
        //In second Dictionary add elements of String type as Key and Int as Value.
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary-1=int as Key and String as Value"); 
            Dictionary<int,string> dic1=new Dictionary<int, string>();
            dic1.Add(1, "Science");
            dic1.Add(2, "History");
            dic1.Add(3, "Geography");
            dic1.Add(4, "Math");
            dic1.Add(5, "Algebra");
            foreach (KeyValuePair<int,string> subject in dic1)
                Console.WriteLine(subject.Key+" "+subject.Value);
            Console.WriteLine("---------------------------");
            
            Console.WriteLine("Dictionary-2=String type as Key and Int as Value");
            Dictionary<string, int> dic2 = new Dictionary<string, int>();
            dic2.Add("Vishal", 22);
            dic2.Add("Taimur", 07);
            dic2.Add("Naresh", 25);
            dic2.Add("Swara", 09);

            foreach (KeyValuePair<string, int> names in dic2)
                Console.WriteLine(names.Key + " " + names.Value);
        }
    }
    class ques12
    {
        //12.	WAP to get only the Keys from a Dictionary.
        
        static void Main(string[] args)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "Science");
            dic1.Add(2, "History");
            dic1.Add(3, "Geography");
            dic1.Add(4, "Math");
            dic1.Add(5, "Algebra");

            Console.Write("Keys from a Dictionary:- ");
            foreach (KeyValuePair<int, string> sub in dic1)
            {
                
                Console.Write(sub.Key+",");

            }
            

        }     
    }
    class ques13
    {
        //13.	WAP to get only the Values from a Dictionary.
        static void Main(string[] args)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "Science");
            dic1.Add(2, "History");
            dic1.Add(3, "Geography");
            dic1.Add(4, "Math");
            dic1.Add(5, "Algebra");

            Console.Write("Values from a Dictionary:- ");
            foreach (KeyValuePair<int, string> sub in dic1)
            {

                Console.Write(sub.Value + ",");

            }
        }
    }
    class ques14:IComparable<ques14>
    {
        //14.	WAP to create a  Dictionary  using Custom class as key and any other object as value
        int Id;
        string Name;

        public ques14(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo(ques14 other)
        {
            return Id.CompareTo(other.Id); //for ascending
        }
        static void Main(string[] args)
        {
            Dictionary<ques14, long> ok = new Dictionary<ques14, long>();
            ok.Add(new ques14(101, "Uddhav"), 7775807645);
            ok.Add(new ques14(102, "Vishal"), 9767207200);
            ok.Add(new ques14(103, "Rajesh"), 9689331949);
            ok.Add(new ques14(104, "Mukesh"), 9604910598);
            ok.Add(new ques14(105, "Pravin"), 9860258100);

            foreach(KeyValuePair<ques14,long> x in ok)
            {
                Console.WriteLine($"{x.Key.Id} {x.Key.Name}  {x.Value}");
            }
        }
    }
    class ques15
    {
        //15.	WAP to create a Queue to add 5 objects and also remove first two and iterate over it.
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            cars.Enqueue("Sumo");
            cars.Enqueue("Swift");
            cars.Enqueue("Brezza");
            cars.Enqueue("Cruiser");
            cars.Enqueue("Scorpio");

            Console.WriteLine("Original Queue");
            foreach (string s in cars)
            { Console.WriteLine(s); }

            string[] toRemove = new string[] { "Sumo", "Swift" };

            //A new queue after removing 1st & 2nd element
            cars = new Queue<string>(cars.Where(obj => !toRemove.Contains(obj)));
            //Console.WriteLine(cars);
            Console.WriteLine(cars);
        }
    }
    class ques16
    {
        //16.	WAP to create a Stack to store some objects and iterate over it.Also show use od push,pop,peek.
        static void Main(string[] args)
        {
            Stack<string> stk=new Stack<string>();
            stk.Push("Safari");
            stk.Push("Vista");
            stk.Push("Indigo");
            stk.Push("Nexon");
            stk.Push("Tiago");

            foreach(string TATA in stk)
            {
                Console.WriteLine(TATA);
            }
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Peek Element: "+stk.Peek());
            Console.WriteLine("POP: "+stk.Pop());
            Console.WriteLine("After POP, Peek Element is: " + stk.Peek());
        }
    }
    /*class Emp
    {
        int id;
        string ename;
        string Dept ;

        public Emp(int id, string ename, string dept)
        {
            this.Id = id;
            this.Ename = ename;
            Dept1 = dept;
        }

        public int Id { get => id; set => id = value; }
        public string Ename { get => ename; set => ename = value; }
        public string Dept1 { get => Dept; set => Dept = value; }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            LinkedList<Emp> ll=new LinkedList<Emp>();
            ll.AddLast(new Emp(1, "AA", new Dept("IT")));
            ll.AddLast(new Emp(2, "BB", new Dept("Sales")));
            ll.AddLast(new Emp(3, "CC", new Dept("Testing")));
            ll.AddLast(new Emp(4, "DD", new Dept("IT")));
            ll.AddLast(new Emp(5, "EE", new Dept("Sales")));
            ll.AddLast(new Emp(10, "FF", new Dept("Testing")));
            ll.AddLast(new Emp(11, "GG", new Dept("IT")));
            ll.AddLast(new Emp(15, "HH", new Dept("Sales")));

            string dname = "";
            foreach(Emp e in ll)
            {
                if(e.Id==10)
                { dname = e.D.Dname;
                    break;

                }
            }
            foreach(Emp ee in ll)
                Console.WriteLine(ee);

            Console.WriteLine("**********************");
            for(int i=0;i<ll.Count;i++)
            {
                Emp ob=ll.ElementAt(i);
                if(ob.D.Dname==dname)
                {
                    ll.Remove(ob);
                }
            }
            for(int i =0;i<ll.Count;i++)
                Console.WriteLine(ll.ElementAt(i));
        }
    }*/
    class ques19
    {
        //19.	WAP to iterate through all elements in a HashSet and print the elements. Observe the order of elements.
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("FarmTrac");
            set.Add("PowerTrac");
            set.Add("John_Deere");
            set.Add("Kubota");
            set.Add("Sonalika");

            foreach(string Tractors in set)
            {
                Console.WriteLine(Tractors);
            }
        }
    }
    public class Order:IComparable<Order>
    {
        int orderid;
        string itemname;
        string city;
        string status;

        public Order(int orderid, string itemname, string city, string status)
        {
            this.Orderid = orderid;
            this.Itemname = itemname;
            this.City = city;
            this.Status = status;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public string City { get => city; set => city = value; }
        public string Status { get => status; set => status = value; }

        public int CompareTo(Order o2)
        {
           return o2.orderid.CompareTo(this.orderid);
        }

        /* public int CompareTo(Order? other)
         {
             throw new NotImplementedException();
         }*/
    }
    class ques20
    {
        static void Main(string[] args)
        {
            List<Order> orderlist = new List<Order>();
            orderlist.Add(new Order(101, "Laptop", "Pune", "Delivered"));
            orderlist.Add(new Order(102, "MusicSysytem", "Pune", "Pending"));
            orderlist.Add(new Order(103, "Mobile", "Mumbai", "Pending"));
            orderlist.Add(new Order(104, "Laptop", "Nashik", "Delivered"));
            orderlist.Add(new Order(105, "TV", "Nashik", "Pending"));
            orderlist.Add(new Order(106, "Mobile", "Pune", "Pending"));

            //key-Cityname Value-count of pending order

            Dictionary<string, int> d1 = new Dictionary<string, int>();
            //Pune=1,Mumbai=1,Nashik=1

            foreach (Order or in orderlist)
            {
                if(d1.ContainsKey(or.City))
                {
                    int oldval= d1[or.City];
                    d1[or.City] = oldval + 1;

                }
                else
                {
                    d1.Add(or.City,1);
                }
            }
            foreach(KeyValuePair<string,int> kv in d1)
                Console.WriteLine(kv.Key+" "+kv.Value);
        }
    }
}
