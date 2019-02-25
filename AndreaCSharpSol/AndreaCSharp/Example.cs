using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreaCSharp
{
    class Example
    {
        public int tall;
        public int low;
        public int total;

        public void Area()
        {
            total = tall * low;
            Console.WriteLine("This is the total {0}", total);
            Console.WriteLine();
            Console.ReadLine();
        }

        public void Newcount()
        {
            total = tall*low*2;
            Console.WriteLine("This is the new total {0}", total);
        }

    }
}
