using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Stack
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myStack = new Stack();

            myStack.Push(10);
            myStack.Push("XXXXX");
            myStack.Push(13M);

            System.Console.WriteLine( myStack.Pop() );
            System.Console.WriteLine( myStack.Pop() );
            System.Console.WriteLine( myStack.Pop() );

            myStack.Push("Take on me");
            myStack.Clear();
            System.Console.WriteLine(myStack.StackList.Count);            
        }
    }
}
