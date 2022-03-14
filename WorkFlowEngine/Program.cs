namespace WorkFlowEngine
{
    class Program
    {
        public static void Main(string[] args)
        {
            var workFlowEng = new WorkFlowEngine( new ServerScript() );
            workFlowEng.Execute();
            workFlowEng = new WorkFlowEngine( new MyScript() );
            workFlowEng.Execute();
        }
    }
}