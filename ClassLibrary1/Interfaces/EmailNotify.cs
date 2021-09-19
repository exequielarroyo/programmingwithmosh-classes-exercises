using System;

namespace ClassLibrary1.Interfaces
{
    class EmailNotify : INotify
    {
        public void Notify()
        {
            Console.WriteLine("Notifying Email...");
        }
    }
}
