/// Alyssa Strand (Mahler)
/// CIS 237 Fall 2016 Assignment 1 
/// Due: Thursday, September 22, 2016
/// 
/// WineItemCollection class - to create and process arrays of WineItems:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
            // Declare backing field:
        private WineItem[] _wineItems;

            // Declare property:
        public WineItem[] WineItems
        {
            set { _wineItems = value; }
            get { return _wineItems; }
        }

            // Default constructor:
        public WineItemCollection()
        {

        }

            // Constructor to save the array:
        public WineItemCollection(WineItem[] wineItems)
        {
            _wineItems = wineItems;
        }

            // Public method to search the array for a specific item by id:
        public void SearchWineItems(string searchId)
        {
                // Set bool condition to false and index to 0 to start:
            bool itemFound = false;
            int indx = 0;
            
                // As long as the item hasn't been found and we haven't run out of items...
            while (itemFound == false && _wineItems[indx] != null)
            {       // Check if the item id matches the search id:
                if (_wineItems[indx].Id == searchId)
                {       // If found, output to user and set itemFound to true to exit the loop:
                    Console.WriteLine();
                    Console.WriteLine(searchId + " was found!");
                    Console.WriteLine(_wineItems[indx].Id + " " + _wineItems[indx].Description +
                        " " + _wineItems[indx].Pack);
                    Console.WriteLine();
                    itemFound = true;
                }
                else
                {       // If the ids don't match, increment the index to search the next item:
                    indx++;
                }
            }
                // If the loop exits without finding a matching id, output failure to user:
            if (itemFound == false)
            {
                Console.WriteLine();
                Console.WriteLine("That item ID does not exist.");
                Console.WriteLine();
            }
        }

            // Public method to find the current last place in the array:
        public int FindLastPlace()
        {
                // Set the current place (index) to 0:
            int lastPlace = 0;

                // As long as the current item is not null, increment the index:
            while (_wineItems[lastPlace] != null)
            {
                lastPlace++;
            }

                // Once the first null item is found, return its index:
            return lastPlace;
        }
    }
}
