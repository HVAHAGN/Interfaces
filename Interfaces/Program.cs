using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*An interface is defined as a syntactical contract that all the classes inheriting 
     * the interface should follow. The interface defines the 'what' part of the syntactical 
     * contract and the deriving classes define the 'how' part of the syntactical contract.
     Interfaces define properties, methods, and events, which are the members of the interface. 
     Interfaces contain only the declaration of the members. It is the responsibility of the deriving
     class to define the members. It often helps in providing a standard structure that the deriving classes would follow.*/
    interface IInterface
    {
        void Method();
    }

    class MyClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод - реализация Интерфейса.");
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass my = new MyClass();

            my.Method();

            //Delay.
            Console.ReadKey();
        }
    }
}
