using System;

namespace _2FunctionsSwitchesAndLists
{
    class Program
    {
        static double alePrice = 10.50;    // Term: Member variable. As opposed to a local variable, a local of a function.
        static double coffeePrice = 10.99; // It is a variable that is a member of the class 'Program'.
        static double teaPrice = 5.25;     // These three can be seen by all functions within Program.

        static void Main(string[] args)
        {
            while (true) // Machine is powered on. :>
            {
                // Greet user.
                Console.WriteLine("Hello and welcome to the Midgård Station drinks machine!");

                // Get money from user.
                double moneyInMachine = InsertMoney(); // See definition on line 92.  It calculates a value, and then brings it back to assign to moneyInMachine, a double.

                do
                {
                    PrintMenu(); // See definition on line 81.

                    // Request selection.
                    Console.Write("Please pick the item you would like to purchase, or press 'E' to eject: ");
                    string userSelection = Console.ReadLine().ToLower();

                    // Check selection is valid.
                    if (userSelection == "01" || userSelection == "ale")
                    {
                        // Did they insert enough to buy an ale?
                        if (moneyInMachine < alePrice)
                        {
                            Console.WriteLine("You poor shit.");
                        }
                        else
                        {
                            moneyInMachine = moneyInMachine - alePrice;
                            Console.WriteLine("Enjoy your ale!");
                        }
                    }
                    else if (userSelection == "02" || userSelection == "coffee")
                    {
                        if (moneyInMachine < coffeePrice)
                        {
                            Console.WriteLine("Sucks to suck.");
                        }
                        else
                        {
                            moneyInMachine = moneyInMachine - alePrice;
                            Console.WriteLine("Your hot, steaming coffee will be out shortly!");
                        }
                    }
                    else if (userSelection == "03" || userSelection == "tea")
                    {
                        if (moneyInMachine < teaPrice)
                        {
                            Console.WriteLine("Eat shit and die.");
                        }
                        else
                        {
                            moneyInMachine = moneyInMachine - teaPrice;
                            Console.WriteLine("Enjoy your tea!");
                        }
                    }
                    else if (userSelection == "e")
                    {
                        Console.WriteLine("Dispensing " + moneyInMachine + "...");
                        moneyInMachine = 0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we dont have that...");
                    }
                    Console.WriteLine("Current Credit: £" + moneyInMachine); // Print out credit remaining.
                } while (moneyInMachine > 0); // If any money in machine, print menu and ask again.
            }
        }

        static void PrintMenu() // I'm void, so I don't return anything.
        {
            // The old menu now lives here.  It only runs top-to-bottom, like it did before.
            Console.WriteLine("Take a look at our stock and choose wisely:");
            Console.WriteLine();
            Console.WriteLine("01. Ale - £" + alePrice);
            Console.WriteLine("02. Coffee - £" + coffeePrice);
            Console.WriteLine("03. Tea - £" + teaPrice);
            Console.WriteLine();
        }

        static double InsertMoney() // I return a data type of double.
        {
            double moneyInMachine = 0; // Temporary placeholder; lives only in InsertMoney().
            do
            {
                Console.Write("How much would you like to insert? ");
                string userInput; // Temporary storage in the form of a string.
                userInput = Console.ReadLine(); // Put the input into the temporary string.
                double.TryParse(userInput, out moneyInMachine); // Try to change the temporary string input into the temporary double from line 94.  
                                                                // If it succeeds, spit it 'out' to moneyInMachine; if it fails, do nothing.
            } while (!(moneyInMachine > 0)); // Check if the amount entered was greater than 0; if not, ask for money again.
            Console.WriteLine("You entered: {0}", moneyInMachine); // Tell the user how much they entered, because reasons.
            Console.WriteLine();
            return moneyInMachine; // Look at the value in moneyInMachine, and bring that back to the place InsertMoney() was called (i.e. line 19).
        }

        // Totally how Console.ReadLine() works...
        static string MyReadLine() // I return a data type of string.
        {
            string consoleLine = "";
            // Pretend we're looking at the console.
            consoleLine = "01"; // Pretend they entered 01.
            return consoleLine; // Return "01"
        }
    }
}
