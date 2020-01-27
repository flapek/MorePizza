using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;
using MorePizza.Model;
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
            List<PizzaModel> list = new List<PizzaModel>()
            {
                new PizzaModel(0,2),
                new PizzaModel(2,6),
                new PizzaModel(3,8),
            };
            string expected = "3\n0 2 3\n";
            string result = DataCreator.CreateString(list);

            Assert.AreEqual(expected, result);
        }
    }
}
