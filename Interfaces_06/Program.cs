using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_06
{
    // / Inherit an interface from an interface whose members have the same name.
    interface IInterface1
    {
        void Method();
    }

    interface IInterface2 : IInterface1
    {
        // Without new, there will be no error, but there will be a compiler warning.
        new void Method();
    }

    class ConcreteClass : IInterface2
    {
        void IInterface1.Method()
        {
            Console.WriteLine("Method - interface IInterface1 implementation");
        }

        void IInterface2.Method()
        {
            Console.WriteLine("Method - interface IInterface2 implementation");
        }
    }

    class program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            //instance.Method ();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}
