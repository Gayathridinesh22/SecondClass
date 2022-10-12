using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class addition
    {
        int a, b;
        public addition()
        {
            a = 100;
            b = 175;
        }
        public static void Main()
        {
            addition obj = new addition();
            Console.WriteLine(obj.a);
            Console.WriteLine(obj.b);
            Console.Read();
        }
    }
}

    

