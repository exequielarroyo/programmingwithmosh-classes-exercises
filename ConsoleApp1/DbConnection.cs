using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new InvalidOperationException("Connection string is emtpy.");
            ConnectionString = connectionString;
        }

        public abstract void Open();
        public abstract void Close();
    }

    class DbCommand
    {
        private DbConnection _connection;
        private string _command;
        public DbCommand(DbConnection connection, string command)
        {
            if (connection is null || String.IsNullOrEmpty(command))
                throw new InvalidOperationException("The connection is null.");
            _connection = connection;
            _command = command;
        }

        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Command executed.");
            _connection.Close();
        }
    }
}
