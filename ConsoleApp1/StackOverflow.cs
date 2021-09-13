using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StackOverflow
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        int votes = 0;
        public int Votes { get { return votes; } }

        public StackOverflow(string title, string description)
        {
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
        }

        public void UpVote()
        {
            if (votes >= 0)
                votes++;
        }
        public void DownVote()
        {
            if (votes > 0)
                votes--;
        }
    }
}
