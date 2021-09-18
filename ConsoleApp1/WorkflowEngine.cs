using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WorkflowEngine
    {
        private readonly IList<IActivity> _workflows;

        public WorkflowEngine()
        {
            _workflows = new List<IActivity>();
        }

        public void Run()
        {
            foreach (var workflow in _workflows)
                workflow.Execute();
        }

        public void Add(IActivity activity)
        {
            _workflows.Add(activity);
        }
    }
}
