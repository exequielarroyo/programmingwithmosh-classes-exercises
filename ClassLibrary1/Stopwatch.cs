using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Stopwatch
    {
        bool isDone;
        DateTime initialTime;
        TimeSpan timeSpan;
        public string GetResult { get { return timeSpan.TotalMilliseconds.ToString(); } }
        
        public void Start()
        {
            if (isDone) throw new InvalidOperationException("Already started.");
            isDone = true;
            initialTime = DateTime.Now;
        }
        public void Stop()
        {
            if (!isDone) throw new InvalidOperationException("Already stoped.");
            isDone = false;
            timeSpan = DateTime.Now - initialTime;
        }
    }
}
