using System;

namespace ConsoleApp1
{
    class SmsNotify : INotify
    {
        public void Notify()
        {
            Console.WriteLine("Notifying SMS...");
        }
    }
}
