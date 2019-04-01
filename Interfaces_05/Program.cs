using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_05
{
    // Inherit the interface from the interface.
    interface IInterface1
    {
        void Method1();
    }

    interface IInterface2 : IInterface1
    {
        void Method2();
    }

    class ConcreteClass : IInterface2
    {
        public void Method1()
        {
            Console.WriteLine("Method1 - interface IInterface1 implementation");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 - interface IInterface2 implementation");
        }
    }

    class program
    {
        static void Main()
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method1();
            instance.Method2();

            IInterface1 instance1 = instance as IInterface1;
            instance1.Method1();

            IInterface2 instance2 = instance as IInterface2;
            instance2.Method1();
            instance2.Method2();

            // Delay.
            Console.ReadKey();
        }
    }
}