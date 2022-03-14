namespace WorkFlowEngine
{
    public interface IWorkFlow
    {
        void Add(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }

    public class WorkFlow : IWorkFlow
    {
        private List<IActivity> Activities { get; set; }

        public WorkFlow()
        {
            Activities = new List<IActivity>();
        }

        public void Add(IActivity activity)
        {
            Activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return Activities;
        }
    }
}