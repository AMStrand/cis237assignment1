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
            // Declare backing fields:
        private string _addItemId;
        private string _addItemDescription;
        private string _addItemPack;

            // Declare properties:
        public string AddItemId
        {
            set { _addItemId = value; }
            get { return _addItemId; }
        }
        public string AddItemDescription
        {
            set { _addItemDescription = value; }
            get { return _addItemDescription; }
        }
        public string AddItemPack
        {
            set { _addItemPack = value; }
            get { return _addItemPack; }
        }

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

            // Public method to add an item to the wine list:
        public void AddWineItem()
        {
            // Ask user for input for new item:
            Console.WriteLine("Enter a new wine item.");
            Console.Write("Enter an ID: ");
            _addItemId = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a description: ");
            _addItemDescription = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a pack size: ");
            _addItemPack = Console.ReadLine();
            Console.WriteLine();
        }

        // Public method to print the wine list:
        public void PrintWineList(WineItem[] items)
        {
                // Reset the string to be blank:
            string allOutput = "";

                // Loop to add items to the string:
            for (int x = 0; x < 9999; x++)
            {
                if (items[x] != null)
                {
                    allOutput += items[x].ToString() + Environment.NewLine;
                }
            }
                // Print the string:
            Console.WriteLine(allOutput);
        }

            // Public method to output an error message to the user if the wine list is empty:
        public void EmptyWineListOutput()
        {
            Console.WriteLine();
            Console.WriteLine("The wine list does not contain any items yet.");
            Console.WriteLine("Try importing the wine list file.");
            Console.WriteLine();
        }
    }
}
