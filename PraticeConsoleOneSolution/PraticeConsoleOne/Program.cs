using System;
using PraticeConsoleOne.InterfacingInterfaces;
using PraticeConsoleOne.PropGetSet;

namespace PraticeConsoleOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string greetings = "Good morning";
            //Console.WriteLine(greetings);
            //Console.WriteLine();

            ////interpolation
            //string firstname = "tayo";
            //Console.WriteLine(firstname);
            //Console.WriteLine();
            //string lastname = "kate";
            //Console.WriteLine(lastname);
            //Console.WriteLine();
            //Console.WriteLine("My name is {0} {1}", firstname, lastname);
            //Console.WriteLine();
            //Console.WriteLine("My name is " + firstname + " " + lastname);
            //Console.WriteLine("Please enter your name");
            //string enterUserName = Console.ReadLine();

            //if (enterUserName.Equals("Andre"))

            //{
            //    Console.WriteLine("My name is Andre");
            //}

            //else if (enterUserName.Equals("Folake"))
            //{
            //    Console.WriteLine("My name is Folake");
            //}

            //else if (enterUserName.Equals("Chi"))
            //{
            //    Console.WriteLine("My name is Chi");
            //}

            //else
            //{
            //    Console.WriteLine("Your name is not recognise");
            //}

            /*
             Console.WriteLine("Please enter your name");
             string enterUserName = Console.ReadLine();
             */

            //if (enterUserName.Equals("Andre") ||
            //    enterUserName.Equals("Folake") ||
            //    enterUserName.Equals("Chi") ||
            //    enterUserName.Equals("Chinwe"))

            //{
            //    Console.WriteLine("My name is {0}", enterUserName);
            //}

            //else
            //{
            //    Console.WriteLine("Your name is not recognise");
            //}

            /*
            switch (enterUserName)
            {
                case "Andre":
                Console.WriteLine("My name is Andre");
                break;
            case "Folake":
                Console.WriteLine("My name is Folake");
                break;
                
            case "Chi":
                 Console.WriteLine("Your name is Chi");
                 break;
                    
                default:
                 Console.WriteLine("Your name is not recognise");
                break;

            }

            */

            /*
            Square square = new Square();
            square.GetArea();
            square.LengthRoot();

            Triangle triangle = new Triangle();
            triangle.TriangleArea(4.5, 5.5);

            Rectangle rectangle = new Rectangle();
            rectangle.RectangleArea(11, 22);
                
            */

            /*
            Square square = new Square();
            square.GetArea();

            //Square squareTwo = new Square();
            //squareTwo.LengthRoot();
            square.LengthRoot();

            Triangle triangle = new Triangle();
            triangle.TriangleArea(4.5, 5.5 );

            Rectangle rectangle = new Rectangle();
            rectangle.RectangleArea(11, 22);
            double le = rectangle.lng = 2.2;
            double he = rectangle.he = 3.3;
            double newArea = le * he;
            Console.WriteLine(newArea + "Print me");


            Console.WriteLine("---------------------");
              
            */

            //ConstructingConstructors cc = new ConstructingConstructors(54, "Ade", 44);
            //ConstructingConstructors cc = new ConstructingConstructors();
            //cc.PrintDetails();

            /*
            StaticMethods sm = new StaticMethods();
            sm.SetAnimalName("Lion");
            sm.GetAnimalName();

            StaticMethods.Animal = "Penguin";
            sm.GetAnimalName();

            */


            //Let us call ConstructorClass2

            /*
            ConstructorsClass2 class2 = new ConstructorsClass2(4, 3, "breathes fire");
            class2.Blackdragon();
           // class2.AddMethod();
            //class2.AddMethod(1, 3);
            //class2.AddMethod(34, 44);

            */

            /*
        //let us create anpother object
        ConstructorsClass2 blueclass = new ConstructorsClass2(2, 3, 4, 2, 2, "This is a nonsense dragon");
        blueclass.BlueDragon();

            */

            /*
            InheriCode inheriCode = new InheriCode();
            string callingKay = inheriCode.KayName;
            Console.WriteLine(callingKay);

            inheriCode.DeclareAge();
            */

            /*
            CallParentDetails callParent = new CallParentDetails();
            string callYourParents = callParent.ParentName;
            callParent.Name();
            Console.WriteLine(callYourParents);
            */

            /*
            CallParentDetails callParent = new CallParentDetails("Lagos State");
            var callYourParents = callParent.ParentName;
            callParent.Name();
            Console.WriteLine(callYourParents);
            */

            /*
            var callParent = new CallParentDetails("");
            callParent.CallFromTheBaseClass();
            */


            /*
            Triangle tri = new Triangle();
            var pn = tri.ParentName;
            Console.WriteLine(pn);

             */

            /*
            FinalAbstract childAbs = new FinalAbstract();
            childAbs.AddNumbers(22, 11);
            childAbs.DisplayTotalSum();

            childAbs.SubNumber(25, 14);
            childAbs.DisplayTotalSub();
            */

            /*
            IParentInterface iparent = new ChildInterfaceCall();
            iparent.DisplayNumber(22);
            iparent.DisplayNumber(33, 12);

            Console.WriteLine("----------------------");

            */

            /*
            IExtendedFamily iExtend = new ChildInterfaceCall();
            int reveal = iExtend.RevealExtendedNumber(44);
            Console.WriteLine("The hidden number is {0}", reveal);

            Console.WriteLine("----------------------");


            iparent = new GrandInterfaceCall();
            iparent.DisplayNumber(44);

            iparent.DisplayNumber(99, 22);

            Console.WriteLine("----------------------");

            */
            // now let us call "props"
            
            
            Props props = new Props();
            props.SetHiddenVariable("Wale"); // we need to set the value first
            

          //  props.GetHiddenVariable(); // now we will get the value
            string revealVariable = props.GetHiddenVariable(); // this will now reveal the variable you set
           Console.WriteLine(revealVariable); // this displays it on the console
            //another way to do this if yo do not want to declear extra variable
            //in "string revealVariable = props.GetHiddenVariable();

         
            //Console.WriteLine(props.GetHiddenVariable());

            
            /*
            var showProps = new Props {ShowVariable = "Wale"};
            Console.WriteLine(showProps.ShowVariable);
            */
            Console.WriteLine();
            Console.WriteLine("Press any key to leave the console window");
            Console.ReadKey();


        }
    }
}
