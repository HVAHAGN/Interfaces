using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_09
{
    // Inheritance of abstract classes from interfaces.
    interface Interface

    {

        void Method();
    }

    abstract class AbstractClass : Interface
    {
        // Replacing an abstract method from an interface in an abstract class is required.
        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        // Implementation of an abstract method from an abstract class in a concrete class is required.
        public override void Method()
        {
            Console.WriteLine("Method - interface implementation in an abstract class.");
        }
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

