using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_02
{
    class DerivedClass : Interface1, Interface2
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
