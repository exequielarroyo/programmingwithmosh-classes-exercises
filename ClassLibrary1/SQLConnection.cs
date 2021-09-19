using ClassLibrary1;
using System;

namespace ClassLibrary1
{
    public class SQLConnection : DbConnection
    {
        public SQLConnection(string connectionString) : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("SQLConnection is opened.");
        }

        public override void Close()
        {
            Console.WriteLine("SQLConnection is closed.");
        }
    }
}
