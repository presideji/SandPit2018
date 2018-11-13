using System;
using PraticeConsoleOne.ExceptionErrors;

namespace PraticeConsoleOne.InterfacingInterfaces
{
    public class ChildInterfaceCall : IParentInterface, IExtendedFamily
    {
        private int _dNum;
        public void DisplayNumber(int aNum)
        {
            try
            {
                Console.WriteLine("Display  {0} & {1} from ChildClass", aNum);
                //throw new NullReferenceException("THIS WAS THROWN BY WALE THE CUSTOM CLASS");
                //Let us try another way
                throw new CustomErrors("THIS WAS THROWN BY WALE");
            }
            //catch (FormatException e)
            //another way to do this
            catch (Exception e)
            //catch (CustomErrors e)
            {
                Console.WriteLine(e.StackTrace);
                //throw;
            }
            finally
            {
                Console.WriteLine("FINALLY BLOCK SHOULD BE DISPLAY");
            }

        }

        public void DisplayNumber(int bNum, int cNum)
        {
            Console.WriteLine(_dNum = bNum - cNum);
        }

        public int RevealExtendedNumber(int fNum)
        {
            return fNum;
        }
    }
}
