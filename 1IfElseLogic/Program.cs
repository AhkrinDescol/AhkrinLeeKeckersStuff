using System;
using System.Collections.Generic;

// alt + 92 for \ 
// alt + 124 for |
// \n for new-line

//string aSentence;
//double aBigNumber;
//float aShitDecimalNumber;
//int aNumber;
//Int32 aNumberToo;
//long aBiggerNumber;
//Int64 aBiggerNumberToo; 

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            double myOnePoundThing = 1.00;
            double myOtherDouble = 3.21343;
            Console.WriteLine("myDouble is currently: " + myOnePoundThing); //   Both do the same thing.
            Console.WriteLine("myDouble is currently: {0}", myOnePoundThing); // ^^^
            Console.WriteLine("myDouble rounded to two places is: {0:0.##}", myOnePoundThing);

            Console.WriteLine("myDouble is {0}, and myOtherDouble is {1}", myOnePoundThing, myOtherDouble); // Prints both doubles.
            Console.WriteLine("myDouble is {0}, myDouble is {1}, and myDouble is {2}", myOnePoundThing, myOnePoundThing, myOnePoundThing); // Prints the same double three times.

            //string wantsToEnterName;
            //Console.Write("Do you want to enter your name? (Y/N): ");
            //wantsToEnterName = Console.ReadLine();
            //
            //Console.WriteLine(); // New line.
            //
            //if (wantsToEnterName == "Y" || wantsToEnterName == "y" || wantsToEnterName == "Yes") // Term: Condition
            //{
            //    Console.Write("Please enter your name: ");
            //    string myName = ""; // Term: Initialise (set a default at time of creation)
            //    myName = Console.ReadLine();
            //
            //    Console.WriteLine("Hello, " + myName + "!"); // Term: Concatenate
            //}
            //else if (wantsToEnterName == "N")
            //{
            //    Console.WriteLine("Fine then have it your way");
            //    Console.WriteLine("Hello, Anon!");
            //}
            //else
            //{
            //    Console.WriteLine("PEBKAC encountered; disengage safety!");
            //}

            Console.ReadLine(); // Pauses console.
        }
    }
}