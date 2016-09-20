/// Alyssa Strand (Mahler)
/// CIS 237 Fall 2016 Assignment 1 
/// Due: Thursday, September 22, 2016
/// 
/// WineItem class - to create objects for each WineItem:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
            // Backing Field Declarations:
        string _id;
        string _description;
        string _pack;

            // Default Constructor:
        public WineItem()
        {

        }

            // Constructor with 3 parameters:
        public WineItem(string id, string descrip, string pack)
        {
                // Assign the passed values to the backing fields:
            _id = id;
            _description = descrip;
            _pack = pack;
        }

        // Public ToString override method:
        public override string ToString()
        {   
            return this._id.PadRight(8) + this._description.PadLeft(60) + " " + this._pack.PadLeft(15);
        }
    }
}
