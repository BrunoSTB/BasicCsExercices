using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeDatabase
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection()
        {
            Timeout = new TimeSpan(10000);
        }

        public abstract void Open();
        public abstract void Close();
    }
}