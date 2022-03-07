using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeDatabase.Classes
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; private set; }
        public bool Connected = false;

        public DbConnection()
        {
            Timeout = new TimeSpan(10000);
        }

        public abstract void Open();
        public abstract void Close();
    }
}