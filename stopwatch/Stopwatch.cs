using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stopwatch
{
    public class Stopwatch
    {
        public TimeSpan PassedTime { get; set; }

        public Stopwatch()
        {
            PassedTime = TimeSpan.Zero;
        }

        public void Start()
        {
            System.Console.Write("Press any key to START the stopwatch: ");
            Console.ReadKey();
            Stop();
        }

        public void Stop()
        {
            do
            {
                var timeCounter = DateTime.Now;            
                System.Console.Write("\nPress any key to STOP the stopwatch: ");
                Console.ReadKey();
                PassedTime = DateTime.Now - timeCounter + PassedTime;
                System.Console.WriteLine("\nTime passed: {0}", PassedTime);
            } 
            while( Continue() );
        }

        public bool Continue()
        {
            System.Console.WriteLine("\nTo exit press 'e', to continue press any other key: ");
            if( Console.ReadKey().KeyChar == 'e' ) 
                return false;
            return true;
        }
    }
}