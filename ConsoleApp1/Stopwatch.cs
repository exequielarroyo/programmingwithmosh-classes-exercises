using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Stopwatch
    {
        bool isDone = true;
        DateTime initialTime;
        TimeSpan timeSpan;
        public string GetResult { get { return timeSpan.Seconds.ToString(); } }
        
        public void Start()
        {
            if (!isDone) throw new InvalidOperationException("Already started.");
            isDone = false;
            initialTime = DateTime.Now;
        }
        public void Stop()
        {
            if (isDone) throw new InvalidOperationException("Already stoped.");
            isDone = true;
            timeSpan = DateTime.Now - initialTime;
        }
    }
}
