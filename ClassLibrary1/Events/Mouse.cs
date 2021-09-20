using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Events
{
    public class Mouse
    {
        public void MouseClicked(object source, EventArgs args)
        {
            Console.WriteLine("Mouse clicked.");
        }
    }
}
