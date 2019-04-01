using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 instance1 = new DerivedClass();
            Interface2 instance2 = new DerivedClass();

            instance1.Method1();
            //instance1.Method2();

            //instance2.Method1(); not available
            instance2.Method2();

            Console.ReadLine();
        }
    }
}
