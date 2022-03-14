namespace WorkFlowEngine
{
    class Program
    {
        public static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.Add( new MyScript() );
            workFlow.Add( new ServerScript() );
        
            var workFlowEngine = new WorkFlowEngine( workFlow );
            workFlowEngine.Execute(); 
        }
    }
}