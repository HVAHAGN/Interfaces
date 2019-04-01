using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_10
{
    // Inheritance from class and interface whose member signatures match.
    interface IInterface
    {
        void Method();
    }

    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method ()");
        }
    }

    class DerivedClass : BaseClass, IInterface
    {
        // Implementation of the interface is not necessary, because,
        // method signatures in the class and interface are the same.
    }

    class program
    {
        static void Main()
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            IInterface instance1 = instance as IInterface;
            instance1.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
}
