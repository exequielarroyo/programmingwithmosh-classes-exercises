
using System;

namespace ClassLibrary1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection is closed.");
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection is opened.");
        }
    }
}
