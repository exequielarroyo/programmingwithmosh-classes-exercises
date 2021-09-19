using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class VideoRecord : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video record updating database: PROCESSING");
        }
    }
}
