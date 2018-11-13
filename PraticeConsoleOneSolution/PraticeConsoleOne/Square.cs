using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne
{
    public class Square

    {
        // these variables have been dedclared outside any methods
        public double Length = 2.6;
        public double Breath = 5.6;

        public void GetArea()
        {
            double squareArea = Length * Breath;
            Console.WriteLine("Area of the square is {0}", squareArea);
        }

        public double LenghtRoot()
        //we did not use void bcos we have used it above, so we use  "double"
        {
            double rootLength = Length + Length;
            return rootLength;
        }
    }
}
