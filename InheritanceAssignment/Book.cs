using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Book : LibraryItem
    {
        private int pageCount;
        //gotta add : base() to pass up to higher constructor
        public Book(string title, string author, int pageCount) 
            : base(title, author)
        {
            //initialize any new constructor args here
            this.pageCount = pageCount;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Page Count: " + pageCount);
        }
    }
}
