using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;
using System.Collections.Generic;

namespace DataTest
{
    [TestClass]
    public class DataTest
    {
        [TestMethod]
        public void TestCreateData()
        {
            List<int> list = new List<int>() { 0, 2, 3 };
            string expected = "3\n0 2 3\n";
            string result = DataCreator.CreateString(list);

            Assert.AreEqual(expected, result);
        }
    }
}
