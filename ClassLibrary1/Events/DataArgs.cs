using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Events
{
    public class DataArgs : EventArgs
    {
        public string Username { get; set; }
    }
}
