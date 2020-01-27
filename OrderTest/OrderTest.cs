using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;
using MorePizza.Model;
using System.Collections.Generic;

namespace OrderTest
{
    [TestClass]
    public class OrderTest
    {
        /// <summary>
        /// Metoda sprawda czy odpowiednio dzielona jest tablica list na obiekt order
        /// </summary>
        [TestMethod]
        public void TestOrder()
        {
            List<int> expected = new List<int>() { 2, 5, 6, 8 };
            string[] orderList = new string[] { "17", "4", "2", "5", "6", "8" };

            Order order = new Order(orderList);
            Assert.AreEqual(expected[0], order.Pizzas[0].SlicesOfPizza);
        }

        /// <summary>
        /// Metoda sprawda czy metoda generuj¹ca zamówienie zwraca odpowiednie indeksy
        /// </summary>
        [TestMethod]
        public void TestGenerateOrder()
        {
            List<int> expected = new List<int>() { 0, 2, 3 };
            string[] list = new string[] { "17", "4", "2", "5", "6", "8" };

            Order order = new Order(list);
            List<PizzaModel> result = order.GenerateOrder();

            Assert.AreEqual(expected[1], result[1].PizzaId);
        }
    }
}
