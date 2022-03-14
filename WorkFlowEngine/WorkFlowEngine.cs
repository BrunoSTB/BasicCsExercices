namespace WorkFlowEngine
{
    class WorkFlowEngine
    {
        private readonly IWorkFlow _workFlow;
        public WorkFlowEngine(IWorkFlow workFlow)
        {
            _workFlow = workFlow;
        }

        public void Execute()
        {
            var Activities = _workFlow.GetActivities();
            foreach (var activity in Activities)
            {
                activity.Run();
            }            
        }
    }
}