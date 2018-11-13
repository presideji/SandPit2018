using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.StaticVariables
{
    public class StaticMethods
    {
        //1 - thi sis a ststic variable called 'Age'
        public static string Animal;


        //from program.cs,no.3
        // non static variable
        public int Boy;


        //2 - let us create a method. the below is a non static, method
        //and it is refrencing the static variable above
        public void SetAnimalName(string newAnimalName)
        {
            Animal = newAnimalName;
        }

        //3-go to program.cs
        public void GetAnimalName()
        {
            //this variable is init Age

        }


    }

}
