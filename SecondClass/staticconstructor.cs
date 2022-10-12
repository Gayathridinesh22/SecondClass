using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
   internal class staticconstructor
    {
        public staticconstructor()
        {
            Console.WriteLine("Instructor Constructor");
        }
        static staticconstructor()
        {
            Console.WriteLine("static Constructor");
        }
        class staticcheck
        {
            static void Main()
            {
                staticconstructor T1 = new staticconstructor();
                staticconstructor T2 = new staticconstructor();

                Console.Read();
            }
        }
    }
}
