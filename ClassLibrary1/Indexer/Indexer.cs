using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Indexer
    {
        private readonly Dictionary<string, IActivity> workflows;

        public Indexer()
        {
            this.workflows = new Dictionary<string, IActivity>();
        }

        public IActivity this[string key]
        {
            get { return this.workflows[key]; }
            set { this.workflows[key] = value; }
        }
    }
}
