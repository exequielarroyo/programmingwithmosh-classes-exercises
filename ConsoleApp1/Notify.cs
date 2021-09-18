using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Notify : IActivity
    {
        private readonly IList<INotify> notify;

        public Notify()
        {
            this.notify = new List<INotify>();
        }

        public void Execute()
        {
            foreach (var notify in this.notify)
            {
                notify.Notify();
            }
        }

        public void Add(INotify notify)
        {
            this.notify.Add(notify);
        }
    }
}
