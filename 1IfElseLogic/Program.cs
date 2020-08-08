using System;

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
            string wantsToEnterName;
            Console.Write("Do you want to enter your name? (Y/N): ");
            wantsToEnterName = Console.ReadLine();

            Console.WriteLine(); // New line.

            if (wantsToEnterName == "Y" || wantsToEnterName == "y" || wantsToEnterName == "Yes") // Term: Condition
            {
                Console.Write("Please enter your name: ");
                string myName = ""; // Term: Initialise (set a default at time of creation)
                myName = Console.ReadLine();

                Console.WriteLine("Hello, " + myName + "!"); // Term: Concatenate
            }
            else if (wantsToEnterName == "N")
            {
                Console.WriteLine("Fine then have it your way");
                Console.WriteLine("Hello, Anon!");
            }
            else
            {
                Console.WriteLine("PEBKAC encountered; disengage safety!");
            }

            Console.ReadLine(); // Pauses console.
        }
    }
}