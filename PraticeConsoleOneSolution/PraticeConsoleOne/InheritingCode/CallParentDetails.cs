using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.InheritingCode
{
    // this is know as the "derived class"
    public class CallParentDetails : ParentClass
    {
        private string _newaddress = "Ibadan State";
        public CallParentDetails(string newstateName) : base(newstateName)
        {
            newstateName = _newaddress;
            Console.WriteLine("I now live at {0}:", newstateName);
        }

        public void CallFromTheBaseClass()
        {
            base.numberTwo = 22;
            base.numberThree = 44;
            base.SetNumberTwo(7777);
            base.SetBothMethods();
        }

    }
}
