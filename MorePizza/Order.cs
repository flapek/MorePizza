using MorePizza.Model;
using System.Collections.Generic;
using System.Linq;

namespace MorePizza
{
    public class Order
    {
        public int MaximumSlice { get; private set; }
        public int TypesOfPizza { get; private set; }
        public List<PizzaModel> Pizzas { get; private set; }
        public Order(string[] order)
        {
            var res1 = int.TryParse(order[0], out int maxSlice);
            var res2 = int.TryParse(order[1], out int typesOfPizza);
            if (res1 && res2)
            {
                MaximumSlice = maxSlice;
                TypesOfPizza = typesOfPizza;
            }
            Pizzas = new List<PizzaModel>();

            int pizzaId = 0;
            for (int i = 2; i < order.Length; i++)
            {
                var res3 = int.TryParse(order[i], out int slices);
                if (res3)
                {
                    if (order[i] != "")
                    {
                        Pizzas.Add(new PizzaModel(pizzaId, slices));
                        ++pizzaId;
                    }
                }
            }
        }

        public List<PizzaModel> GenerateOrder()
        {
            // Policzenie sumy wszystkich kawałków
            var SumOfSlices = Pizzas.Sum(x => x.SlicesOfPizza);

            // Jeżeli wszystkie pizze mogą zostać zamówione, to zamawiamy wszystkie
            if (SumOfSlices <= MaximumSlice) return Pizzas;

            // Sortujemy liste pizz'cami wg. ilości kawałków malejąco
            Pizzas = Pizzas.OrderByDescending(x => x.SlicesOfPizza).ToList();

            // Tworzymy liste z gotowym zamówieniem
            var resultOrder = new List<PizzaModel>();

            // Aktualna ilość kawałków
            int CurrentSlices = 0;

            // Dobieramy pizze, która zmieści się w zadanym ograniczeniu
            foreach (var pizza in Pizzas)
            {
                if (pizza.SlicesOfPizza + CurrentSlices <= MaximumSlice)
                {
                    CurrentSlices += pizza.SlicesOfPizza;
                    resultOrder.Add(pizza);
                }
            }

            // Sortujemy pizze wg. identyfikatora
            resultOrder = resultOrder.OrderBy(x => x.PizzaId).ToList();
            return resultOrder;
        }
    }
}