using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeDatabase
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
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
                    System.Console.WriteLine("Connected do SQL Database.");
                    break;
                }
            }
        }

        public override void Close()
        {
            System.Console.WriteLine("Closing connection to SQL Database.");
        }
    }
}