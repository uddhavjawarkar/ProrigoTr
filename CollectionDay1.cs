using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoTr
{

    //Non Generic
     class K
    {
        private object ob;
        public object Ob { get => ob; set => ob = value; }  
    }

    //Generic
    class KK<T>
    {
        public T ob;
        public T Ob { get => ob; set => ob = value; }
    }
    class TTest
    {
        static void Main(string[] args)
        {
            KK<string> obj = new KK<string>();
            obj.Ob = "hhh";
            string s = obj.Ob;

            K k = new K();
            k.Ob = "sima";
            k.Ob = 90;

            int m = (int)k.Ob;
        }
    }


}
