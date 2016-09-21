/// Alyssa Strand (Mahler)
/// CIS 237 Fall 2016 Assignment 1 
/// Due: Thursday, September 22, 2016
/// 
/// UserInterface class - to handle input and output interactions with the user:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
            // Public method to prompt the user for an input choice and return that value:
        public int UserOptionsPrompt()
        {
                // Create a variable to hold the user's choice and set to 0:
            int userChoice = 0;
            
                // Output the choices to the user:
            Console.WriteLine("Please choose an option from the list:");
            Console.WriteLine("1: Load the wine list.");
            Console.WriteLine("2: Print the wine list.");
            Console.WriteLine("3: Search the wine list.");
            Console.WriteLine("4: Add to the wine list.");
            Console.WriteLine("5: Exit.");

                // Attempt to parse the user input to an integer and save as userChoice to return:
            if (int.TryParse(Console.ReadLine(), out userChoice) == true && userChoice > 0 && userChoice < 6)
            {       // If parse succeeds and is within the limits, return the choice selected:
                return userChoice;
            }
            else
            {       // If parse fails (input was not an integer or wasn't 1-5), output error message:
                Console.WriteLine();
                Console.WriteLine("That is not a valid option.");
                Console.WriteLine();
                return 0;
            }
        }

        public void AddWineItem()
        {
            Console.WriteLine("Enter a new wine item.");
            Console.Write("Enter an ID: ");
            string id = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a description: ");
            string description = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a pack size: ");
            string pack = Console.ReadLine();
            Console.WriteLine();


        }

        public void PrintWineList(WineItem[] items)
        {
            string allOutput = "";

            for (int x = 0; x < 9999; x++)
            {
                if (items[x] != null)
                {
                    allOutput += items[x].ToString() + Environment.NewLine;
                }
            }

            Console.WriteLine(allOutput);
        }


    }
}
