using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class ParamConstructor
    {
        public int a, b;
        public ParamConstructor(int x , int y)
        {
            a = x;
            b = y;
        }
        class MainClass
        {
            static void Main()
            {
                ParamConstructor v = new ParamConstructor(100, 175);
                Console.WriteLine("..........parameterized Constructor example of Vithal.........");
                Console.WriteLine("\t");
                Console.WriteLine("value of a=" + v.a);
                Console.WriteLine("value of b=" + v.b);
                Console.Read();
            }

        }
    }
}
