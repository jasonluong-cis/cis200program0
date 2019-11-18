// Program 0
// CIS 200-01
// Due: 1/29/2018
// By: Z9467

// File: LibraryPatron.cs
// This file creates a simple LibraryPatron class capable of tracking
// the patron's name and ID.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron
{
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron


    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id)
    {
        PatronName = name;
        PatronID = id;
    }

    public string PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition:  None
        // Postcondition: The patron's name has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PatronName)} must be filled"); 
                //Precondition: has to have nothing filled in
                //Postcondition: returns an error message telling what to do to fix it
            }
            _patronName = value.Trim();
        }
    }
    public string PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  None
        // Postcondition: The patron's ID has been set to the specified value
        set
        {
           if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PatronID)} must be filled");
            }
            //Precondition: has to have nothing filled in
            //Postcondition: returns an error message telling what to do to fix it
            _patronID = value.Trim();
        }
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }

}

