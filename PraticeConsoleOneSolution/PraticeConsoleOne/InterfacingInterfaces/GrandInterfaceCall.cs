using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.InterfacingInterfaces
{
   public class GrandInterfaceCall : IParentInterface
   {
       private int _eNum;
        public void DisplayNumber(int aNum)
        {
            Console.WriteLine("Display {0} from ChildClass", aNum);
        }

        public void DisplayNumber(int bNum, int cNum)
        {
            Console.WriteLine(_eNum = bNum - cNum);
        }
    }
}
