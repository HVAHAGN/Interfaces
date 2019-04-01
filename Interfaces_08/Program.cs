using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_08
{
    // Inherit from interfaces whose member names match.Combining the implementation of the same abstract members.

    // 

    namespace Interfaces
    {
        interface IInterface1
        {
            void Method();
        }

        interface IInterface2
        {
            void Method();
        }

        class ConcreteClass : IInterface1, IInterface2
        {
            public void Method()
            {
                Console.WriteLine("Method - interface IInterface implementation (1-2)");
            }
        }

        class program
        {
            static void Main()
            {
                ConcreteClass instance = new ConcreteClass();
                instance.Method();

                IInterface1 instance1 = instance as IInterface1;
                instance1.Method();

                IInterface2 instance2 = instance as IInterface2;
                instance2.Method();

                // Delay.
                Console.ReadKey();
            }
        }
    }
}
