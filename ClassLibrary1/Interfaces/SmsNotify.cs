using System;

namespace ClassLibrary1
{
    public class SmsNotify : INotify
    {
        public void Notify()
        {
            Console.WriteLine("Notifying SMS...");
        }
    }
}
