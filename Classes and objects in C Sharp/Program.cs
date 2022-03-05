using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects_in_C_Sharp
{
    class Program
    {
        static void Main()
        {
            Book bible = new Book();
            bible.SetTitle();
            bible.SetAuthor();

            Console.WriteLine(bible.GetTitle());
            Console.WriteLine(bible.GetAuthor());
            List<Book> books = new List<Book>();
            books.Add(new Book());
            books[0].SetAuthor(bible.GetAuthor());
            books[0].SetTitle(bible.GetTitle());
            bible.SetAuthor();
            Console.WriteLine(books[0].GetAuthor());
            Console.WriteLine(bible.GetAuthor());
        }
    }
}