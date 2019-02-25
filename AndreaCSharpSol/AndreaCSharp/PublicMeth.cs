using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreaCSharp
{
    public class PublicMeth : PriMeth
    {
        public int age;
        public string name;

        public void StudentDetails()
        {
            Console.WriteLine("{0} is {1} years old", name, age);
        }


    }
}
