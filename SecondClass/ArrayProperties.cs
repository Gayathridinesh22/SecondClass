using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    internal class ArrayProperties
    {
        static void printarray(int[] arr)
        {
            Console.WriteLine("\n Elements of array is:\n");
            foreach(int i in arr)
            {
                Console.WriteLine("\t{0}", i);
            }
            Console.Write("\n");
                
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[5] { 43, 25, 33, 14, 5 };
            int[] arr2 = new int[5];
            int len, rank;
            bool fixedsize, read_only;

            len = arr1.Length;
            Console.WriteLine("Length :\t{0}", len);

            rank = arr1.Rank;
            Console.WriteLine("Rank :\t{0}", rank);

            fixedsize = arr1.IsFixedSize;
            Console.WriteLine("FixedSize :\t{0}", fixedsize);

            read_only = arr1.IsReadOnly;
            Console.WriteLine("FixReadOnlySize :\t{0}", read_only);

            Array.Sort(arr1);
            printarray(arr1);

            Console.WriteLine("Get Length :\t{0}", arr1.GetLength(0));

            Console.WriteLine("Get Value :\t{0}", arr1.GetValue(2));

            Console.WriteLine("Get Index :\t{0}", Array.IndexOf(arr1,43));

            Array.Copy(arr1, arr2, 5);
            printarray(arr2);

            Array.Clear(arr1, 0, 2);
            printarray(arr1);

            Console.ReadLine();


        }
    }
}
