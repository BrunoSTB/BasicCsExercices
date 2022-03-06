using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeDatabase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConnectToOracle();
            ConnectToSql();
        }

        public static void ConnectToSql()
        {
            var oracle = new OracleConnection("OracleConnectionString");
            oracle.Open();
            oracle.Close();
        }

        public static void ConnectToOracle()
        {
            var sql = new SqlConnection("SqlConnectionString");
            sql.Open();
            sql.Close();
        }
    }
}
