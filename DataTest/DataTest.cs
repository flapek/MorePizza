using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;
using System.Collections.Generic;

namespace DataTest
{
    [TestClass]
    public class DataTest
    {
        /// <summary>
        /// Metoda sprawda czy w odpowiedni sposób jest tworzony tekst wynikowy
        /// </summary>
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
