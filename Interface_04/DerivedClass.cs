using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_04
{
    // In C #, multiple inheritance from interfaces is allowed.
    // Multiple inheritance of an implementation (that is, from two or more classes or structures) is unacceptable.
    // Allowed multiple inheritance from a single class and many interfaces.
    class DerivedClass: BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Implementation of Method Method1 () from Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Implementation of Method Method2 () from Interface2");
        }
    }
}
