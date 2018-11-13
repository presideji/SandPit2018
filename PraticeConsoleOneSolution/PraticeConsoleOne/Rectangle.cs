using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne
{
    class Rectangle
    {
        //public double he;
        //public double lng;

        public Rectangle()
        {
            Console.WriteLine("This is a constructor");
        }

        //this is 2nd consructor
        public Rectangle(double l, double h)
        {
            //l = he;
           // h = lng;

        }

        public void RectangleArea(double height, double length)
            {
            double area = height * length;
            Console.WriteLine("Area of Rectangle is: {0}",area);

            }



    }
}
