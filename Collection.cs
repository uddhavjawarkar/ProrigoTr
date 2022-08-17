using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{
    internal class Collection
    {
        static void Main(string[] args)
        {
            string s1 = "aayush";
            char[] arr=s1.ToCharArray();
            //key===> character and value is count

            Dictionary<char,int> d1=new Dictionary<char,int>(); 
            //[p=1,a=2,r=2,m=1,e=1,s=1]
            /**
             */
             foreach(char ch in arr)
            {
                if(d1.ContainsKey(ch))
                {
                    int curval=d1[ch];
                    d1[ch]=curval+1;
                }
                else
                    d1.Add(ch,1);
            }
           
        }
    }
    class sortedListDemo
    {
        static void Main(string[] args)
        {
            //Maintains data in sorted order of key
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Priya", 99);
            ss.Add("Riya", 99);
            ss.Add("Diya", 99);
            ss.Add("Hiya", 99);
            ss.Add("Kiya", 99);
            ss.Add("Tiya", 99);
            ss.Add("Siya", 99);
            ss.Add("Ankush", 99);

            ss.Remove("Hiya");
            ss["Kiya"] = 90;
            Console.WriteLine(ss.ContainsKey("AA"));
            Console.WriteLine(ss.Count); 

            foreach(var d in ss)
            { Console.WriteLine(d.Key+ " ===> " + d.Value); }
        }
    }
    class SBSort : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder? x, StringBuilder? y)
        {
            return x.ToString().CompareTo(y.ToString());
        }
    }

    class Demoss3
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> ss = new SortedList<StringBuilder, int>(new SBSort());
            ss.Add(new StringBuilder("Amit"), 90);
            ss.Add(new StringBuilder("Amita"), 90);
            ss.Add(new StringBuilder("Adu"), 90);
            ss.Add(new StringBuilder("Ciya"), 90);

            foreach(var kv in ss)
                Console.WriteLine(kv.Key+" ===> "+kv.Value);

        }
    }
    class sortByprice : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Price.CompareTo(y.Price);  
        }
    }
    class sortByAuthorname : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
           return x.Authorname.CompareTo(y.Authorname); 
        }
    }
    class Book:IComparable<Book>    
    {
        int bookid;
        string bookname;
        string authorname;
        int price;

        public Book(int bookid, string bookname, string authorname, int price)
        {
            this.Bookid = bookid;
            this.Bookname = bookname;
            this.Authorname = authorname;
            this.Price = price;
        }

        public int Bookid { get => bookid; set => bookid = value; }
        public string Bookname { get => bookname; set => bookname = value; }
        public string Authorname { get => authorname; set => authorname = value; }
        public int Price { get => price; set => price = value; }

        public int CompareTo(Book other)
        {
            return this.bookname.CompareTo(other.bookname);
        }

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   bookid == book.bookid &&
                   bookname == book.bookname &&
                   authorname == book.authorname &&
                   price == book.price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(bookid, bookname, authorname, price);
        }
    }
    class books
    {
        static void Main(string[] args)
        {
            HashSet<string> hs=new HashSet<string>();
            hs.Add("Amit");
            hs.Add("Amita");
            hs.Add("Amey");
            bool x = hs.Add("Amit");
             foreach(string s in hs)    
                Console.WriteLine(s);

            HashSet<Book> hs2 = new HashSet<Book>();
            hs2.Add(new Book(1, "Java", "Kantekar", 900));
            hs2.Add(new Book(1, "Java", "Kantekar", 900));

            foreach(Book b in hs2)
            {
                Console.WriteLine(b);
            }
        }
    }
}
