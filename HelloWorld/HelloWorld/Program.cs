using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World");
            Console.ReadLine();
            */
            /* int x;
             int y;
             x = 7;
             y = x + 3;
             Console.WriteLine(y);
             Console.ReadLine();
             Console.ReadKey();
             */

            /* Console.WriteLine("What is your name?");
             Console.WriteLine("Type your first name");

             string myFirstName;
             myFirstName = Console.ReadLine();
             Console.WriteLine();
             */

            //string myLastName;
            //Console.WriteLine("Type your last name");
            //myLastName = Console.ReadLine();
            //Console.WriteLine();

            /* Console.WriteLine("Type your last name");
             string myLastName = Console.ReadLine();

             Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
             Console.WriteLine();
             //Interpolation
             Console.WriteLine("My name is {0} {1}", myFirstName, myLastName);
             Console.ReadKey();
             */

            /*  Console.WriteLine("Bob Big Games");
              Console.WriteLine("Choose a door: 1, 2 or 3: ");
              string userValue = Console.ReadLine();

              string message = "";
              if (userValue == "1")
             //string message = "You won a new car!";
                  message = "You won a new car!";
                  //Console.WriteLine(message);

              else if (userValue == "2")
              //string message = "You won a boat";
                  message = "You won a boat";
                  // Console.WriteLine(message);


              else if (userValue == "3")
              //string message = "You won a new car!";
                  message = "You won a new car!";
                  //Console.WriteLine(message);
              else
              {
                  //string message = " Sorry we do not understand";
                  message = " Sorry we do not understand. ";
                  //Console.WriteLine(message);
                  //message = message + "You Lose.";
                  //another way to write this
                  message += "You Lose.";

              }

              Console.WriteLine(message);
              Console.ReadLine();

                */

            //In a if else situation we can write this as below
            /*Console.WriteLine("Bog Give Away Game");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string useValue = Console.ReadLine();

            string message = (useValue == "1") ? "boat" : "strand of line. ";

            */

            /*Console.WriteLine("You won a ");
            Console.WriteLine(message);
            Console.WriteLine(".");
            Console.ReadLine();
            */
            // Console.WriteLine("You won a {0}.", message);
            //Another way to write it
            /* Console.WriteLine("You entered: {0}, therefore you won a {1}.", useValue, message);
             Console.ReadLine();
             */

            // Console.ReadKey();

            /*
            Console.WriteLine("Bob's Big Games");
            Console.WriteLine("Choose a door: 1, 2 or 3: ");
            string useValue = Console.ReadLine();

            string message = "";
            if (useValue == "1")

                message = "You won a new car!";
            //Console.WriteLine(message);

            else if (useValue == "2")

                message = "You have won a new boat";
            //Console.WriteLine(message);

            else if (useValue == "3")

                message = "You have won a new cat!";
            //Console.WriteLine(message);

            else
            {
                //message = "Sorry, we do not understand.";

                //message = message + "You Lose.";
                message += "You Lose.";
               Console.WriteLine(message);
                Console.ReadLine();
            }
        */

            /*
            int a = 10;
            do
            {
                Console.WriteLine("value of a: {0}", a);
                a++;
            }
            while (a < 20);
            Console.ReadLine();
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                // Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }

            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            */

            /*
             
         

            //ARRAYS
            
            int[] numbers = new int[5];
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;

          //  Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
            Console.ReadLine();

            */

            /*
            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
            */

            /*
             // it allow us to loop through all names in our array
            string[] names = new string[] { "Eddie", "Alex", "Michael", "David Lee" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            /*
            string zig = "You can get what you want in life" +
                "if you help other to get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray)
            {
                Console.WriteLine(zigChar);
            }

              */

            // Methods

            // Console.ReadLine();

            // HelloWorld();
            //Console.ReadLine();


            //We need to call the method

            /*
        private static void HelloWorld()
            {
                Console.WriteLine("Hello World");
                Console.ReadLine();

            }

            */



            /*
             
            bool displaymenu = true;
            while (displaymenu == true)
            {
                 displaymenu = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an opton: ");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")

            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers !");
            Console.WriteLine("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1 )
            {
                Console.WriteLine(counter);
                Console.WriteLine(".");
                counter++;
            }
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing game!");


            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses++;


                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong!");

            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses. ", guesses);


            Console.ReadLine();

        }

            */

            {
                //string myString = "My \"so-called\" life"; // the backsplash is used so that it can appear exactly as typed
                //string myString = "What if I need a\nnew line?";
                //string myString = "Go to your c:\\ drive";
                //string myString = @"Go to your c:\ drive";
                //string myString = String.Format("{1} = {0}", "First", "Second");
                // string myString = string.Format("{0:C}", 123.45); // display currency
                //string myString = string.Format("{0:N}", 1234544445);
                //string myString = string.Format("Percentage: {0:P}", .123); // display percentage
                // string myString = string.Format("Phone Number{0:(###) ###-####}", 1234567890);// way to format numbers
                //string myString = " That summer we took threes across the board  ";
                //myString = myString.Substring(6, 14);
                // myString = myString.ToUpper(); // convert the text That summer we took threes across the board to upper case
                // myString = myString.Replace(" ", "--");//put hyphen in the text "That summer we took threes across the board" 
                // myString = myString.Remove(6, 14);

                /*
            //myString = String.Format("Lenght before: {0} -- Lenght after: {1}",
            //    myString.Length, myString.Trim().Length);
                */

                /*

                string myString = "";
                for (int i = 0; i < 100; i++)
                {
                    myString += "--" + i.ToString();
                }
                 */

                StringBuilder myString = new StringBuilder();
                for (int i = 0; i < 100; i++)
                {
                    myString.Append("--");
                    myString.Append(i);
                }


                Console.WriteLine(myString);
                
                Console.ReadLine();

                  
            }

        }





    }
}
