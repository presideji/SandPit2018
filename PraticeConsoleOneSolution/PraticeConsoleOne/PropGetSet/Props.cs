using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.PropGetSet
{
    public class Props
    {
        //this setter is used to set the value of the variable
        public void SetHiddenVariable(string variableValue)
        {
            
            ShowVariable = variableValue;
            ShowVariable = ShowVariable + " is my name";
        }

        // this getter is used to return value of variable
        public string GetHiddenVariable()
        {
            ShowVariable = ShowVariable + " who am I?";
            return ShowVariable;
        }


        /*
         * 
         * another way to do it
         */
        //public string ShowVariable // theis can be written as show below
        public string ShowVariable { get; set; }
    }
}
