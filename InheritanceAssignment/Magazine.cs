using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class Magazine : LibraryItem
    {
        private int issueNumber;
        public Magazine(string title, string author, int issueNumber)
            : base(title, author)
        {
            this.issueNumber = issueNumber;
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Issue Number: " + issueNumber);
        }
    }
}
