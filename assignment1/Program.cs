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
                // Create and initialize class instances for use:
            WineItem wineItem = new WineItem();
            WineItemCollection wineItemCollection = new WineItemCollection();
            UserInterface userInterface = new UserInterface();
            CSVProcessor csvProcessor = new CSVProcessor();

                // Create and initialize the array for the wine items:
            WineItem[] wineItems = new WineItem[9999];

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
                    case 1: // CSVProcessor method call to load the wine list:
                        string pathToCsvFile = "..\\..\\..\\datafiles\\WineList.csv";       // *** NOTE - THIS WAS DIFFICULT TO CONFIGURE ***
                        
                            // If one of the first lines in the wineItems array is empty, import the csv file:
                        if (wineItems[10] == null)
                        {       // If the import succeeds, assign the array to the WineItemCollection array object:
                            if (csvProcessor.ProcessCsvFile(pathToCsvFile, wineItems) == true)
                            {
                                wineItemCollection.WineItems = wineItems;
                            }
                            else
                            {       // Error message if there is an issue uploading the csv file:
                                Console.WriteLine("There was an error uploading the csv file.");
                                Console.WriteLine();
                            }
                        }
                        else
                        {       // Error message if the csv file has already been loaded:
                            Console.WriteLine("You have already loaded the csv file.");
                            Console.WriteLine();
                        }
                        break;
                    case 2: // Print method call to print the wine list:
                        if (wineItems[0] != null)
                        {       // If there are items, print them:
                            userInterface.PrintWineList(wineItems);
                        }
                        else
                        {       // If not, output error to user:
                            userInterface.EmptyWineListOutput();
                        }
                        break;
                    case 3: // Search method call to search the wine list:
                        if (wineItems[0] != null)
                        {       // If there are items, allow the search:
                            Console.Write("Input the item ID to search for: ");
                                // Call method to search:
                            wineItemCollection.SearchWineItems(Console.ReadLine());
                        }
                        else
                        {       // If the array doesn't contain anything, output error to user:
                            userInterface.EmptyWineListOutput();
                        }
                        break;
                    case 4: // Add WineItem call to add an item to the wine list:
                            // If there are items, allow the add:
                        if (wineItems[0] != null)
                        {       // Get new wine item information from user:
                            userInterface.AddWineItem();
                                // Add the new item in the first open spot in the array:
                            wineItemCollection.WineItems[wineItemCollection.FindLastPlace()] = new WineItem(userInterface.AddItemId, userInterface.AddItemDescription, userInterface.AddItemPack);
                        }
                        else
                        {       // Otherwise, inform the user:
                            userInterface.EmptyWineListOutput();
                        }
                        break;
                    default: // Choice was to exit (5), so break without calling any other method:
                        break;
                }
            }
        }
    }
}
