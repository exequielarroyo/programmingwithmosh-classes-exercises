using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Delegate
{
    public class Delegate
    {
        public delegate void MethodHandler();

        public void Method1()
        {
            Console.WriteLine("Method1 runs...");
        }
        public void Method2()
        {
            Console.WriteLine("Method2 runs...");
        }
        public void Method3()
        {
            Console.WriteLine("Method3 runs...");
        }

        public void Run(MethodHandler methodHandler)
        {
            methodHandler();
        }
    }
}
