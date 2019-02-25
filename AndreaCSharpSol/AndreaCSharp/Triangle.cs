using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AndreaCSharp
{

    public class Triangle
    {
        public int triHeight;   //variable height of triangle
        public int triBase;     //variable base of triangle
        public int areaAnswer;
       
        //this is my first method
        public void TriangleArea()
        {
            areaAnswer = triHeight * triBase;
            Console.WriteLine("The area of this triangle is {0}", areaAnswer);
            Console.WriteLine();
            
        }

        
        //here we are creating another a 2nd method that is returned
        public int SquareArea()
        {
            areaAnswer = (triBase + triHeight) * 2;
            Console.WriteLine("The area of thus Square is {0}", areaAnswer);
            return areaAnswer;
            Console.WriteLine();
        }

        //Third Method
        public void PolygonArea(int parameterOne, int parameterTwo)
        {
            triHeight = parameterOne;
            triBase = parameterTwo;
            areaAnswer = parameterOne / parameterTwo;
            Console.WriteLine("The area of this polygon {0}", areaAnswer);
        }


      

    }
}
