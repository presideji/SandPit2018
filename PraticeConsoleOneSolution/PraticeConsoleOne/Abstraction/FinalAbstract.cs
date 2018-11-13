using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.Abstraction
{
    public class FinalAbstract : ChildAbs
    {
        public override void SubNumbers(int subA, int subB)
        {
            base.numbersSubtracted = subA - subB;
        }
    }


    

}
