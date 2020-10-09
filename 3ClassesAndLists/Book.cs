using System;
using System.Collections.Generic;
using System.Text;

namespace _3ClassesAndLists
{
    public class Book
    {
        public double Rating;
        public string Name;
        public string ISBN;
        public int PageCount;

        public void AssignBookDetails(double rating, string name, 
            string ISBN, int pageCount)
        {
            Rating = rating;
            Name = name;
            this.ISBN = ISBN;
            PageCount = pageCount;
        }

        public void PrintBookInformation()
        {
            Console.WriteLine("Book: {0}", Name);
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Pages in Book: {0}", PageCount);
            Console.WriteLine("Rating: {0}/5", Rating);
        }
    }
}
