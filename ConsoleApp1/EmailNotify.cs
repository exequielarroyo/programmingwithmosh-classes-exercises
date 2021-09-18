using System;

namespace ConsoleApp1
{
    class EmailNotify : INotify
    {
        public void Notify()
        {
            Console.WriteLine("Notifying Email...");
        }
    }
}
