using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.Abstraction
{
   public abstract class AbstractKnowledge
    {
        //This ia a special type of class which is only used for
        //inheritance
        //Abstract is a special type of class which is only used for inheritance 
        //An object of an Abstract class can’t be created
        //An Abstract class can have Abstract method
        //Abstract methods are those methods whose implementation is 
        //defined by the derived class

            //let us crreata some data
        private int _numberOne;
        private int _numberTwo;
        protected int numbersAdded = 0;
        protected int numbersSubtracted = 0;

        //this is a standard method
        public void DisplayTotalSum()
        {
            Console.WriteLine("The addition of both number is: {0} " , numbersAdded);
        }

        public void DisplayTotalSub()
        {
            Console.WriteLine("The subtraction of both numbers is {0} ", numbersSubtracted);
        }

        // this is an abstract method
        public abstract void AddNumbers(int numA, int numB);


        //let us out in another method
      public abstract void SubNumbers(int subA, int subB);

    }
}
