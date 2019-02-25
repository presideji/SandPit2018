using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndreaCSharp.GrandParent;
using AndreaCSharp.Parent;

namespace AndreaCSharp
{
    class Program : PriMeth
    {
        static void Main(string[] args) // this is the main method

        {
            //Triangle triangleIsoceless = new Triangle(); // here i have created an instance of triangle
            //// and I called it "triangleIsoceless"

            //triangleIsoceless.triBase = 10;
            //triangleIsoceless.triHeight = 10;
            //triangleIsoceless.TriangleArea();

            //Console.WriteLine();

            //Triangle rightAngleTriangle = new Triangle();
            //rightAngleTriangle.triBase = 7;
            //rightAngleTriangle.triHeight = 23;
            //rightAngleTriangle.TriangleArea();

            //Console.WriteLine();

            //Triangle SquareCal = new Triangle();
            //SquareCal.triBase = 23;
            //SquareCal.triHeight = 23;
            //SquareCal.SquareArea();

            //Console.WriteLine();

            //Square square = new Square();
            //square.SquareBase = 23;
            //square.SquareHeight = 10;
            //square.SquareFinalArea();

            //Console.WriteLine();

            //Triangle poly = new Triangle();
            //poly.PolygonArea(100, 10);


            ////Example result = new Example();
            ////result.tall = 10;
            ////result.low = 20;
            ////result.Area();

            ////Console.WriteLine();

            ////Example obtain = new Example();
            ////obtain.low = 10;
            ////obtain.tall = 10;
            ////result.Newcount();

            //PublicMeth pm = new PublicMeth();
            //pm.age = 12;
            //pm.name = "Andre";
            //pm.StudentDetails();

            PriMeth priMeth = new PriMeth();
            priMeth.StudentDetails(24, "Ola");
            priMeth.studentSomething();

            GrandP grandP = new GrandP();
            grandP.CallyName();
            Console.WriteLine("Change name to Kelvin");
            grandP.MichaelName = "Kelvin";
            grandP.CallyName();

            Console.WriteLine();

            Guardian guardian = new Guardian();
            guardian.CallParents();



            Console.ReadKey();



        }
    }
}
