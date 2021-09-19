using System.Collections.Generic;

namespace ClassLibrary1
{
    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<object> GetActivities();
    }
}

