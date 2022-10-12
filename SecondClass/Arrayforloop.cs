using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    class Arrayforloop
    {
        static void Main()
        {
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Press enter key to exit...");
            Console.ReadLine();
        }
    }
}
