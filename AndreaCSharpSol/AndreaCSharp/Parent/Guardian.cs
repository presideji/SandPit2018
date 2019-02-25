using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreaCSharp.Parent
{
    public class Guardian
    {
        protected string ParentName;

        public void CallParents()
        {
            Console.WriteLine("my parents name is {0}", ParentName);
        }

        protected void Name()
        {
            Console.WriteLine("my name is still {0}", ParentName);
        }
    }
}
