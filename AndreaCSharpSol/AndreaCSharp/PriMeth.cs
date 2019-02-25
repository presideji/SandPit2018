using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreaCSharp
{
    public class PriMeth
    {
        private int _studentAge;
        private string _studentName;
        protected int Money;
        private int _numberOne = 2;
        private int _numberTwo = 4;

            public void StudentDetails(int age, string name)
            {
              _studentAge = age;
                _studentName = name;
                Console.WriteLine("{0} is {1} years old", _studentAge, _studentName);
                Console.WriteLine("My private calculation is {0}", multiplyMe(5, 3));
            }

        private int multiplyMe(int numA, int numB)
        {
            _numberOne = numA;
            _numberTwo = numB;
            int result = numA*numB;
            return result;
        }

        internal void studentSomething()
        {
            Console.WriteLine("{0} is my age", _studentAge);
            Console.WriteLine("{0} is my name", _studentName);
            Console.WriteLine("{0} is in my bank account", Money);
        }
        
    }
}
