using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Events
{
    public class Click
    {
        //public delegate void ClickEventHandler(object source, EventArgs args);
        //public event ClickEventHandler ClickedEvents;

        public EventHandler<DataArgs> ClickedEvents;

        public void Clicked(string username)
        {
            Console.WriteLine("Clicked");

            OnClicked(username);

        }

        protected virtual void OnClicked(string username)
        {
            if (ClickedEvents != null)
                ClickedEvents(this, new DataArgs() { Username = username });
        }
    }
}
