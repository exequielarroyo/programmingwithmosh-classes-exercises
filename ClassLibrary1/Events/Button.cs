using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Events
{
    public class Button
    {
        public void ButtonClicked(object o, DataArgs args)
        {
            Console.WriteLine($@"Button Clicked. '{args.Username}'");
        }
    }
}
