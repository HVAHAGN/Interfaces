using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_03
{
    class program
    {// Explicitly specifying the interface name in the method name.

        static void Main()
        {
            DerivedClass instance = new DerivedClass();

            // instance. - // On an instance, we do not see interface methods.

            // Give an instance of the class DerivedClass - instance, to the base interface type Interface1

            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
