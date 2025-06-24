using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class LibraryItem
    {
        protected string title;
        protected string author;

        //This constructor can't be called, but it is inherited
        protected LibraryItem(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
        }
    }
}
