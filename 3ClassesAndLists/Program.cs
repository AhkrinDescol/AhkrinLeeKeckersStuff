using System;
using System.Collections.Generic;
using System.Text;

namespace _3ClassesAndLists
{
    class Program
    {
        static void Main()
        {
            // Create reference to a Book, and assign it to look at a new Book.
            Book bookOne = new Book(); 
            // Grab the reference, and tell it to AssignBookDetails to what it's looking at.
            bookOne.AssignBookDetails(-1, "FSOG", "My ISBN 100% Legit", 32); 

            // Do the same again for another Book.
            Book bookTwo = new Book();
            bookTwo.AssignBookDetails(39, "Wee.", "My Other ISBN", 839);

            // Create a third, blank Book.
            Book bookThree = new Book();

            // Create a fourth, blank book.
            Book bookFour = new Book();

            // Create reference to a List that knows to hold several Book references.
            // Create List that knows to hold Book references.
            // Assign reference to a List<Book> to look at the newly created List<Book>.
            List<Book> books = new List<Book>();

            // Add a copied reference (bookOne) to the list of books.
            books.Add(bookOne); // [0]
            // Add another copied reference (bookTwo) immediately after it.
            books.Add(bookTwo); // [1]
            // Again for bookThree.
            books.Add(bookThree); // [2]
            // Again for bookFour.
            books.Add(bookFour); // [3]

            // Look at the first Book reference in the list, and look at its Name.  Then print the Name out.
            Console.WriteLine(books[0].Name); // bookOne.Name
            Console.WriteLine(); // Spacer.

            // Check if the Name of the second book in books is empty.  If it's not, do stuff inside.
            if (!String.IsNullOrWhiteSpace(books[1].Name))
            {
                // Print name of the second book in books.
                Console.WriteLine(books[1].Name); // Equivalent to bookTwo.Name
                Console.WriteLine(); // Spacer.
            }

            // Same again for third book in books.
            if (!String.IsNullOrWhiteSpace(books[2].Name))
            {
                Console.WriteLine(books[2].Name); // bookThree.Name
                Console.WriteLine();
            }

            // Look at the fourth Book reference in the list, and look at its Name. Then print the Name out.
            Console.WriteLine(books[3].Name); // bookFour.Name
            Console.WriteLine();

            // Create reference to a Book.  Tell it to look at the same Book as what bookTwo is looking at.
            Book bookFive = bookTwo; 
            // Screw with bookTwo by using bookFive to update what bookTwo is also looking at.
            bookFive.AssignBookDetails(32, "Not Wee. Any More", "Somewhat Legit ISBN", 3289);
            // Copy bookFive (the reference, not the Book) and add it to the end of the list.
            // Note: [1] and [4] are both separate references to the same Book now!
            books.Add(bookFive); // [4]

            Console.WriteLine("Now calling PrintBookTitles();");
            PrintBookTitles(books);

            //Console.WriteLine(books[4].Name); // bookFive.Name
            //Console.WriteLine(books[1].Name); // Also bookFive.Name?
            //Console.WriteLine();

            // Three ways to do the same thing.
            // The old, crappy way in this file;
            // the newer, better way by asking the named reference; and
            // the newer, better way by asking for the first reference in books.
            //PrintBookInformation(bookOne);
            //bookOne.PrintBookInformation();
            //books[0].PrintBookInformation();

            // Example of lists within lists.  Many Products in a list, and that list inside a list.
            // List<Product> productCoil = new List<Product>();
            // for (int i = 0; i < 50; ++i)
            // {
            //     productCoil.Add(new Product());
            // }
            // List<List<Product>> shelf = new List<List<Product>>();
            // shelf.Add(productCoil);

            Console.ReadLine(); // Pause.
        }

        static void PrintBookTitles(List<Book> books)
        {
            // Clunkier way to go through every 'element' in a list, one by one, in order.
            //for (int i = 0; i < books.Count; ++i)
            //{
            //    // Check the book has a Name, if so, do stuff.
            //    if (!String.IsNullOrWhiteSpace(book.Name))
            //    {
            //        // Look at the i'th element in the list, do PrintBookInformation() on it.
            //        books[i].PrintBookInformation();
            //        Console.WriteLine();
            //    }
            //}

            // Specialised, simpler way of going through every element in a list, one by one, in order.
            foreach (Book book in books)
            {
                // Look at the temporary reference 'book' and check it has a Name.
                if (!String.IsNullOrWhiteSpace(book.Name))
                {
                    // Look at the temporary reference 'book' and run PrintBookInformation() on it.
                    book.PrintBookInformation();
                    Console.WriteLine();
                }
            }
        }

        static void PrintBookInformation(Book book)
        {
            Console.WriteLine("Book: {0}", book.Name);
            Console.WriteLine("ISBN: {0}", book.ISBN);
            Console.WriteLine("Pages in Book: {0}", book.PageCount);
            Console.WriteLine("Rating: {0}/5", book.Rating);
        }

        //static void Main()
        //{
        //    string bookOneName = "The Hobbit";
        //    string bookOneISBN = "6969-HU93C0CK";
        //    int bookOnePageCount = 69;

        //    string bookTwoName = "The Two Towers";
        //    string bookTwoISBN = "42-03HTMBHT";
        //    int bookTwoPageCount = 420;

        //    Book bookThree;
        //    bookThree = new Book();

        //    bookThree.Name = "Fifty Shades of Grey";
        //    bookThree.Rating = -1; // Glorified toilet paper.
        //    bookThree.PageCount = 514;
        //    bookThree.ISBN = "978-1-61213-028-6";

        //    Book bookFour = new Book();
        //    bookFour.Name = "Meep";
        //    bookFour.Rating = 32;
        //    bookFour.PageCount = 3980;
        //    bookFour.ISBN = "2304-TH-39-THN";

        //    PrintBookInformation(bookOneName, bookOneISBN, bookOnePageCount);
        //    Console.WriteLine();
        //    PrintBookInformation(bookTwoName, bookTwoISBN, bookTwoPageCount);
        //    Console.WriteLine();
        //    PrintBookInformation(bookThree.Name, bookThree.ISBN, bookThree.PageCount);
        //    Console.WriteLine();
        //    PrintBookInformation(bookFour.Name, bookFour.ISBN, bookFour.PageCount);
        //    Console.WriteLine();
        //    PrintBookInformation(bookThree);
        //    Console.WriteLine();
        //    PrintBookInformation(bookFour);
        //    Console.WriteLine();
        //    PrintBookInformation(bookThree, true);

        //    Console.ReadLine(); // Pause.
        //}

        //static void PrintBookInformation(string bookName, string bookISBN, int bookPageCount)
        //{
        //    Console.WriteLine("Book: {0}", bookName);
        //    Console.WriteLine("ISBN: {0}", bookISBN);
        //    Console.WriteLine("Pages in Book: {0}", bookPageCount);
        //}

        //static void PrintBookInformation(Book book, bool fancyWay)
        //{
        //    PrintBookInformation(book);
        //    Console.WriteLine("I printed it the fancy way. :>");
        //}

        //static void Main()
        //{
        //    MySimpleFunction();

        //    double mainNumOne = 3.2;
        //    double mainNumTwo = 39203.32;
        //    double mySum = MyAddition(mainNumOne, mainNumTwo);
        //    double myOtherSum = MyAddition(mySum, mainNumTwo);
        //    Console.WriteLine(mySum);
        //    Console.WriteLine(myOtherSum);

        //    Console.ReadLine(); // Pause.
        //}

        //static double MyAddition(double numOne, double numTwo)
        //{
        //    double myFuncSum;
        //    myFuncSum = numOne + numTwo;
        //    return myFuncSum;
        //}

        //static void MySimpleFunction()
        //{
        //    Console.WriteLine("Item 1 - Cost: 1GBP");
        //    Console.WriteLine("Item 2 - Cost: 1.40GBP");
        //    Console.WriteLine("Item 3 - Cost: 2.30GBP");
        //}
    }
}