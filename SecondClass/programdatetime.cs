using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondClass
{
    class programdatetime
    {
        static void Main()
        {
            DateTime dt = new DateTime();
            DateTime dt3 = System.DateTime.Now;
            Console.WriteLine(System.DateTime.Now);

            DateTime date1 = new DateTime(2022, 10, 12);
            Console.WriteLine("Date1:{0}", date1);

            Console.WriteLine("Day:{0}", dt3.Day);
            Console.WriteLine("Day:{0}", dt3.Month);
            Console.WriteLine("Day:{0}", dt3.Year);
            Console.WriteLine("Day:{0}", dt3.Hour);
            Console.ReadKey();

        }
    }
}
    

