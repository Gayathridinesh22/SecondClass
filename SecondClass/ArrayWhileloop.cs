using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
   internal class ArrayWhileloop
    {
       public static void Main()
        {
            int i = 0;
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
            }
                Console.WriteLine("Press enter key to exit....");
                Console.ReadLine();
            }
        }
    }

