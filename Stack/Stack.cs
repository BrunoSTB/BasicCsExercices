using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public List<object> StackList { get; set; }

        public Stack()
        {
            StackList = new List<object>();
        }

        public void Push(object obj) 
        {
            if(obj == null)
                throw new InvalidOperationException("You must pass not null values!");
            this.StackList.Add(obj);
        }

        public object Pop()
        {
            if(StackList.Count == 0)
                throw new InvalidOperationException("There are no items on the stack!");

            var lastObject = StackList[ StackList.Count - 1 ];
            StackList.RemoveAt( StackList.Count - 1 );
            return lastObject;
        }

        public void Clear() =>
            StackList.Clear();
    }
}