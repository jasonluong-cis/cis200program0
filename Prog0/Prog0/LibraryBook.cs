// Program 0
// CIS 200-01
// Due: 1/29/2018
// By: Z9467

// File: LibraryBook.cs
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public const int DEFAULT_YEAR = 2017; // Default copyright year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status

    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }

    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Title)} must be filled");
                //Precondition: has to have nothing filled in
                //Postcondition: returns an error message telling what to do to fix it
            }
            _title = value.Trim();
        }
    }

    public string Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value;
        }
    }

    public string Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            _publisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(Title)} must be filled"); ;
            //Precondition: has to have nothing filled in
            //Postcondition: returns an error message telling what to do to fix it
        }
    }

    public string CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(CallNumber)} must be filled");
                //Precondition: has to have nothing filled in
                //Postcondition: returns an error message telling what to do to fix it
            }
            _callNumber = value.Trim();
        }
    }

    // Precondition:  None
    // Postcondition: The book is checked out
    public void CheckOut(ref LibraryPatron libraryPatron) //references the patrons in LibraryPatron Class
    {
        _checkedOut = true;
    }

    // Precondition:  None
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
        bool? _checkedOut = null; // Returns the checked in book to null
        _checkedOut = _checkedOut.HasValue;
    }

    // Precondition:  None
    // Postcondition: true is returned if the book is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        bool? _checkedOut = null; // makes a newly created book nulled
        return _checkedOut.HasValue; 
    }

    public string Patron
    {
        get;
    }



    // Precondition:  None
    // Postcondition: A string is returned representing the libary book's
    //                data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // Newline shortcut

        return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
            $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}" +
            $"Checked Out By:{Patron}";
    }
}
