using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;
using System.Collections.Generic;

namespace OrderTest
{
    [TestClass]
    public class OrderTest
    {
        private readonly string path1 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_example.in";
        private readonly string path2 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\b_small.in";

        [TestMethod]
        public void TestOrder()
        {
            File file = new File(path1);
            List<int> expected = new List<int>() { 2, 5, 6, 8 };
            string[] list = file.ReadFile();

            Order order = new Order(list);

            Assert.AreEqual(expected[0], order.PizzaSlicesNumbers[0]);
        }

        [TestMethod]
        public void TestGenerateOrder()
        {
            File file = new File(path1);
            List<int> expected = new List<int>() { 2, 6, 8 };
            string[] list = file.ReadFile();

            Order order = new Order(list);
            List<int> result = order.GenerateOrder();

            Assert.AreEqual(expected[2], result[2]);
        }
    }
}