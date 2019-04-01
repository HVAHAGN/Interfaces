using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_03
{
    class DerivedClass : Interface1, Interface2
    {
        // On the 10th line, we will implement a method named Method from the base Interface1
        // When implementing the method, we use the technique of explicitly specifying the name of the interface in the name
        // method to which this method belongs.

        // By default, the methods of the same name are private,
        // but explicitly specify access modifiers is not allowed.
        void Interface1.Method()
        {
            Console.WriteLine("Implementation of Method Method () from Interface1");
        }

        void Interface2.Method()
        {
            Console.WriteLine("Implementation of Method Method () from Interface2");
        }
    }
}
