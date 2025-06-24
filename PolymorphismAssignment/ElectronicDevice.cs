using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    internal class ElectronicDevice
    {
        public virtual void TurnOn()
        {
            Console.WriteLine("Turning on the device.");
        }

        public virtual void TurnOff()
        {
            Console.WriteLine("Turning off the device.");
        }
    }
}
