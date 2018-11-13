using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.InheritingCode
{
    public class InheriCode
    {
        public string KayName = "Kay";

        // other way to protect code or modify it
        private int ChinweAge = 16;

        protected double DimejiScore = 100;



        public void DeclareAge()
        {
            Console.WriteLine("Chinwe is: {0} years old", ChinweAge);
        }


    }
}
