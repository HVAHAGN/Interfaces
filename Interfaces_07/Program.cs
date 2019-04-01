using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_07
{
    // Inheritance of abstract classes from interfaces.

    interface Interface

    {

        void Method();
    }

    abstract class AbstractClass : Interface
    {
        // Implementation of the abstract method from the interface in the abstract class is required.
        public void Method()
        {
            Console.WriteLine("Method - interface implementation in an abstract class.");
        }
    }

    class ConcreteClass : AbstractClass
    {
    }

    class program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            // Delay.
            Console.ReadKey();
        }
    }
}