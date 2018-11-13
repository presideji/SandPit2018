using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.ConstructorsExample
{
    public class ConstructingConstructors
    {
        //1
        public int Age;
        public string Name;
        public int Feet;

        //2. Creat a constructor
        public ConstructingConstructors()
        {

        }

        //3a. create another one
        public ConstructingConstructors(int newAge, string newName, int newFeet)
        {
            Console.WriteLine("My name is {0}, my age is {1} and I have {2} feet", newName, newAge, newFeet);
        }

        public void PrintDetails()
        {
            Feet = 3;
            Name = " Andre";
            Age = 456;
            Console.WriteLine("I am {0}yrs old. Call me {1}, I have {2} feet", Age, Name, Feet);

        }

    }
}
