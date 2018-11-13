using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticeConsoleOne.InheritingCode;

namespace PraticeConsoleOne
{
    //triangle class is inheriting Parentclass
    class Triangle : ParentClass
    {

        public Triangle(string stateName) : base(stateName)
        {

        }
        //we want to create a more smarter method
        public double TriangleArea(double length, double breath)
        {
            double triangleCalc = length * breath;
            return triangleCalc;
           // Console.WriteLine(triangleCalc);.

            
        }

        
    }
}
