using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StackOverflow
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            private set
            {
                if (!String.IsNullOrEmpty(value))
                    _title = value;
            }
        }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int Votes { get; private set; }

        public StackOverflow(string title, string description)
        {
            Votes = 0;
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
        }

        public void UpVote()
        {
            if (Votes >= 0)
                Votes++;
        }
        public void DownVote()
        {
            if (Votes > 0)
                Votes--;
        }
    }
}
