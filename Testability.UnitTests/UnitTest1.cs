using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp1.UnitTests
{
    [TestClass]
    public class DbConnection
    {
        [TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod1()
        {
            var connection = new SQLConnection("awdwad");
            

            Assert.IsTrue(!String.IsNullOrEmpty(connection.ConnectionString));
        }
    }
}
