using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects_in_C_Sharp
{
    class Book
    {
        private string title = "Untitled";
        private string author = "Unnamed";
        public string GetTitle()
        {
            return this.title;
        }

        public string GetAuthor()
        {
            return this.author;
        }
        
        public void SetTitle(string arg = null)
        {
            if (arg == null)
            {
                try
                {
                    Console.Write("Enter the title of the book: ");
                    this.title = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                this.title = arg;
        }

            public void SetAuthor(string arg = null)
        {
            if (arg == null)
            {
                try
                {
                    Console.Write("Enter the name of the author: ");
                    this.author = Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                this.author = arg;
        }
    }
}
