using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreaCSharp
{
    class Program
    {
        static void Main(string[] args) // this is the main method

        {
            Triangle triangleIsoceless = new Triangle(); // here i have created an instance of triangle
           // and I called it "triangleIsoceless"

           triangleIsoceless.triBase = 10;
           triangleIsoceless.triHeight = 10;
           triangleIsoceless.TriangleArea();

           Console.WriteLine();

           Triangle rightAngleTriangle = new Triangle();
           rightAngleTriangle.triBase = 7;
           rightAngleTriangle.triHeight = 23;
           rightAngleTriangle.TriangleArea();

            Triangle SquareCal = new Triangle();
            SquareCal.triBase = 23;
            SquareCal.triHeight = 23;
            SquareCal.SquareArea();

            Console.WriteLine();

            Triangle poly = new Triangle();
            poly.PolygonArea(100, 10);


            Console.ReadKey();

        }
    }
}
