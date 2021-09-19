using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IActivity flow in workflow.GetActivities())
                flow.Execute();
        }
    }

    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _workflows;

        public Workflow()
        {
            _workflows = new List<IActivity>();

        }
        public void Add(IActivity activity)
        {
            _workflows.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _workflows.Remove(activity);
        }

        public IEnumerable<object> GetActivities()
        {
            return _workflows;
        }
    }
}
