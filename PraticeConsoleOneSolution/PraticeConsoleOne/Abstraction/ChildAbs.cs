using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.Abstraction
{
    public abstract class ChildAbs : AbstractKnowledge
    {
        public override void AddNumbers(int numA, int numB)
        {
            base.numbersAdded = numA + numB;
        }

        //public override void SubNumbers(int subA, int subB)
        //{
        //    base.numbersSubtracted = subA - subB;
        //}
    }
}
