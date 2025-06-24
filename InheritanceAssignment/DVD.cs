using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignment
{
    internal class DVD : LibraryItem
    {
        private int duration;

        public DVD(string title, string author, int duration) 
            : base(title, author)
        {
            this.duration = duration; 
        }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Duration: " + duration);
        }
    }
}
