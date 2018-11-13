using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.InheritingCode
{

    //this is the baseClass
    //and is sometimes referred to as the Supper Class
    public class ParentClass
    {
        public string ParentName = "Dada";

        private int _parentAccountBalance = 1000000;

        protected string DaughterName = "Chinwe";

        private string _whereParentsLive = "Edo State";


        // Base Keyword, More Access Modifiers & More Constructors
        // 1. let us creat a consructor
        public ParentClass(string stateName)
        {
            stateName = _whereParentsLive;
            Console.WriteLine("My parents live at {0}:", stateName);
        }

        //==================================================================

        private int _numberOne;
        protected int numberTwo;
        public int numberThree;

        private void SetNumberOne(int alphaNum)
        {
            alphaNum = _numberOne;
            Console.WriteLine("alphaNum is {0}", alphaNum);
        }
        
        protected void SetNumberTwo(int betaNum)
        {
            betaNum = numberTwo;
            Console.WriteLine("beteNum is {0}", betaNum);
        }

        public void SetBothMethods()
        {
            Console.WriteLine("The values of numberOne & numberTwo are {0} & {1} are: ", numberTwo, numberThree);
        }



        /*

        public void Name()
        {
            Console.WriteLine("My parents surname is {0}", ParentName);

        }

        public void Balance()
        {
            Console.WriteLine("My parents surname is {0}", _parentAccountBalance);

        }

        public void Daughter()
        {
            Console.WriteLine("My name is {0}", DaughterName);

        }

        */

    }
}
