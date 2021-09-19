using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Generic
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class Max<T> where T : struct, IComparable
    {
        public T GetMax(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }

    public class Database<Connection> where Connection : DbConnection, new()
    {
        List<Connection> connections;
        public Database(Connection connection)
        {
            connections = new List<Connection>();
            connections.Add(connection);

            // where T : new()
            Connection con = new Connection();
        }
    }

    public struct MyStruct : IComparable
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public int CompareTo(object obj)
        {
            return 0;
        }
    }
}
