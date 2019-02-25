using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreaCSharp
{
    public class Square
    {
        public int SquareBase;
        public int SquareHeight;
        public int SquareArea;


        public void SquareFinalArea()
        {
            SquareArea = SquareBase * SquareHeight;
            Console.WriteLine("The final area of this Square is {0}", SquareArea);
            Console.WriteLine();

        }

    }
}
