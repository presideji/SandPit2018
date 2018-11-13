using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeConsoleOne.InterfacingInterfaces
{
    public interface IParentInterface
    {
        void DisplayNumber(int aNum);
        //now let us overload this
        void DisplayNumber(int bNum, int cNum);
    }
}
