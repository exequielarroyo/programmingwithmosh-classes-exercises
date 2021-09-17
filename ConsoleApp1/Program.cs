using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStack = new Stack();
            myStack.Push(1);
            Console.WriteLine($"List: {myStack.Peek()}");
            myStack.Push("Hello world");
            Console.WriteLine($"List: {myStack.Peek()}");
            Console.WriteLine($"Remove: {myStack.Pop()}");
            Console.WriteLine($"Remove: {myStack.Pop()}\nList: {myStack.Peek()}");


            Console.ReadLine();
        }
    }
}
