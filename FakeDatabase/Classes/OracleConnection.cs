using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeDatabase.Classes
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
        {
            if( string.IsNullOrEmpty(connectionString) )
                throw new InvalidOperationException("You should pass a valid connection string!");

            ConnectionString = connectionString;
        }


        public override void Open()
        {
            using( var cts = new CancellationTokenSource( Timeout ) )
            {
                cts.Token.Register(() => { throw new TimeoutException(); });
                while(!cts.IsCancellationRequested)
                {
                    Connected = true;
                    System.Console.WriteLine("Connected to Oracle Database.");
                    break;
                }
            }
        }

        public override void Close()
        {
            if(Connected != true)
                throw new InvalidOperationException("You are not connected to any database!");

            Connected = false;
            System.Console.WriteLine("Closing connection to SQL Database.");
        }
    }
}