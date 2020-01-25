using System;
using System.Collections.Generic;
using System.Linq;

namespace MorePizza
{
    public class Order
    {
        public int MaximumSlice { get; private set; }
        public int TypesOfPizza { get; private set; }
        public List<int> PizzaSlicesNumbers { get; private set; }
        public Order(string[] list)
        {
            var res1 = int.TryParse(list[0], out int maxSlice);
            var res2 = int.TryParse(list[1], out int typesOfPizza);
            if (res1 && res2)
            {
                MaximumSlice = maxSlice;
                TypesOfPizza = typesOfPizza;
            }
            PizzaSlicesNumbers = new List<int>();
            for (int i = 2; i < list.Length; i++)
            {
                var res3 = int.TryParse(list[i], out int slices);
                if (res3)
                {
                    if (list[i] != "")
                        PizzaSlicesNumbers.Add(slices);
                }
            }
        }

        public List<int> GenerateOrder()
        {
            double sum = PizzaSlicesNumbers.Sum();
            List<int> resultOrder = new List<int>();
            double odds = sum - MaximumSlice;
            if (odds <= 0)
            {
                resultOrder = PizzaSlicesNumbers;
            }
            else
            {
                List<int> numbers = SearchNumbers(odds);
                resultOrder = PizzaSlicesNumbers;
                foreach (var number in numbers)
                    resultOrder.Remove(number);
            }

            return resultOrder;
        }

        private List<int> SearchNumbers(double odds)
        {
            List<int> result = new List<int>();
            bool searchDone = false;

            do
            {
                if (odds >= PizzaSlicesNumbers.Last())
                    break;

                result.AddRange(PizzaSlicesNumbers.Where(item => item == odds).Select(item => item));

                if (result.Sum() == odds)
                    searchDone = true;

                ++odds;

            } while (!searchDone);

            if (!searchDone)
            {                 
                result = SearchSplitedOdds(odds);
            }

            return result;
        }

        private List<int> SearchSplitedOdds(double odds)
        {
            List<int> result = new List<int>();
            bool searchDone = false;
            do
            {
                for (int i = PizzaSlicesNumbers.Count - 1; i >= 0; i--)
                {
                    result.Add(PizzaSlicesNumbers[i]);
                    for (int j = 0; j < i - 1; j++)
                    {
                        var resultSum = result.Sum();
                        if (resultSum + PizzaSlicesNumbers[j] == odds)
                        {
                            searchDone = true;
                            result.Add(PizzaSlicesNumbers[j]);
                            break;
                        }
                        else if (resultSum + PizzaSlicesNumbers[j] <= odds)
                        {
                            result.Add(PizzaSlicesNumbers[j]);
                        }
                        else
                        {
                            result.Clear();
                            break;
                        }
                    }
                    if (searchDone)
                        break;
                    else
                        result.Clear();
                }
                odds++;
            } while (!searchDone);

            return result;
        }
    }
}