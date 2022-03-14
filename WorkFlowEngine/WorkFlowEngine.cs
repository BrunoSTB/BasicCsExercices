namespace WorkFlowEngine
{
    class WorkFlowEngine
    {
        private readonly IActivity _activity;
        public WorkFlowEngine(IActivity activity)
        {
            _activity = activity;
        }

        public void Execute()
        {
            _activity.Run();
        }
    }
}