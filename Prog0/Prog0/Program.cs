// Program 0
// CIS 200-01
// Due: 1/29/2018
// By: Z9467

// File: Program.cs
// This program modifies a program that validates various data and then alters the layout of the final result

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "Andrew Wright", "UofL Press",
            2010, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2000, "AG773 ZF"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1985, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            2016, "ZZ24 4F");    // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2001, "AE842 7A"); // 5th test book

        // Test list of books
        List<LibraryBook> books = new List<LibraryBook>
        {
            book1,
            book2,
            book3,
            book4,
            book5
        };


        //Library Patrons
        LibraryPatron patron1 = new LibraryPatron("Johnny", "1234");
        LibraryPatron patron2 = new LibraryPatron("Peter", "4567");
        LibraryPatron patron3 = new LibraryPatron("Alexis", "7890");


        WriteLine("Original list of books");
        WriteLine("----------------------");
        foreach( var book in books)
        {
            WriteLine(book);
        }

        Pause();

        // Make changes
        book1.CheckOut(ref patron1);
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(ref patron2);
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(ref patron3);
        book5.CopyrightYear = 1995; // Attempt invalid year

        WriteLine("After changes");
        WriteLine("-------------");
        foreach (var book in books)
        {
            WriteLine(book);
        }
        Pause();

        // Return the books
        book1.ReturnToShelf();
        book3.ReturnToShelf();
        book5.ReturnToShelf();

        WriteLine("After returning the books");
        WriteLine("-------------------------");
        foreach (var book in books)
        {
            WriteLine(book);
        }
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(LibraryBook[] books)
    {
        foreach (LibraryBook b in books)
        {
            Console.WriteLine(b);
            Console.WriteLine();
        }
    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();

        Console.Clear(); // Clear screen
    }
}
