using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class ArrayForeach
    {
        static void Main()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press enter enter to exit...");
            Console.ReadLine();
        }
    }
}
