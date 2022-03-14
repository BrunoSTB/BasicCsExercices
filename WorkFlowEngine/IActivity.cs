namespace WorkFlowEngine
{
    public interface IActivity
    {
        public void Run();
    }

    public class MyScript : IActivity
    {
        public void Run()
        {
            System.Console.WriteLine("Running Script!");
        }
    }

      public class ServerScript : IActivity
    {
        public void Run()
        {
            System.Console.WriteLine("Running Server script!");
        }
    }
}