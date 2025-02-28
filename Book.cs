using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment
{
    class Book
    {
        public Book(string Title)
        {
            Console.WriteLine("Default Constructor: ");
            Console.WriteLine("Title: " + Title);
        }

        public Book(string Title, string Author)
        {
            Console.WriteLine("Parameterized Constructor: ");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }

        public Book(string Title, string Author, int ISBN)
        {
            Console.WriteLine("Parameterized Constructor: ");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
    }
}
