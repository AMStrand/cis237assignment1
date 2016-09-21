/// Alyssa Strand (Mahler)
/// CIS 237 Fall 2016 Assignment 1 
/// Due: Thursday, September 22, 2016
/// 
/// CSVProcessor class - to handle input from a csv file:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public bool ProcessCsvFile(string pathToCsvFile, WineItem[] wineItems)
        {
                // Create the streamReader object and set to null:
            StreamReader streamReader = null;

                // Try/catch structure to attempt to read the csv file:
            try
            {
                    // Create a string to hold the input line:
                string wineItem;
                    // Attempt to instantiate the streamreader based on the csv file's location:
                streamReader = new StreamReader(pathToCsvFile);
                    // Start a line counter and set to 0:
                int counter = 1;
                    // Loop so that as long as the line read in isn't blank, process the line:
                while ((wineItem = streamReader.ReadLine()) != null)
                {
                    ProcessWineItem(wineItem, wineItems, counter++);
                }
                    //  Return true if the process works:
                return true;
            }
            catch (Exception ex)
            {       // Error message and return false if csv file import fails:
                Console.WriteLine("You have a problem: " + ex.Message);
                return false;
            }
            finally
            {
                    // If the streamReader object is not blank, close it!
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

            // Method to read in each wine item from the list and split and save the sections:
        private void ProcessWineItem(string item, WineItem[] items, int count)
        {
            string[] parts = item.Split(',');
            string id = parts[0];
            string description = parts[1];
            string pack = parts[2];

                // Saves each item in its place in the array:
            items[count] = new WineItem(id, description, pack);
        }
    }
}
