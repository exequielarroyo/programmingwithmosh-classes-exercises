using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = new ClassLibrary1.Delegate.Delegate();

            ClassLibrary1.Delegate.Delegate.MethodHandler methodHandler = new ClassLibrary1.Delegate.Delegate().Method1;
            methodHandler += NewMethod1;
            methodHandler += new ClassLibrary1.Delegate.Delegate().Method2;

            process.Run(methodHandler);

            Console.ReadLine();
        }

        static void NewMethod1()
        {
            Console.WriteLine("NewMethod1 runs...");
        }
    }
}
