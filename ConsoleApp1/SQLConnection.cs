using System;

namespace ConsoleApp1
{
    class SQLConnection : DbConnection
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
