/// Alyssa Strand (Mahler)
/// CIS 237 Fall 2016 Assignment 1 
/// Due: Thursday, September 22, 2016
/// 
/// This program is used for coordination of a list of wine items where the user can load the wine list
///     from a file, print the list, add to the list, and search the list for an item by its ID.  


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
                // Initialize userInterface object in UserInterface class:
            UserInterface userInterface = new UserInterface();

                // Create a variable for the user's choice and set to 0:
            int userChoice = 0;

                // While the user's choice is not to exit, loop:
            while (userChoice != 5)
            {
                    // Call public method in UserInterface class to start user prompt and save user choice:
                userChoice = userInterface.UserOptionsPrompt();

                    // Call the appropriate method based on the user's choice:
                switch (userChoice)
                {
                    case 1: // CSVProcessor method call:
                        Console.WriteLine("1");
                        break;
                    case 2: // Print method call:
                        Console.WriteLine("2");
                        break;
                    case 3: // Search method call:
                        Console.WriteLine("3");
                        break;
                    case 4: // Add WineItem call:
                        Console.WriteLine("4");
                        break;
                    default: // Choice was to exit, so break without calling any other method:
                        break;
                }
            }
        }
    }
}
