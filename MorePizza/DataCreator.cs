﻿using MorePizza.Model;
using System.Collections.Generic;
using System.Text;

namespace MorePizza
{
    public class DataCreator
    {
        public DataCreator()
        {
        }

        public static string CreateString(List<PizzaModel> order)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"{order.Count}\n");
            for (int i = 0; i < order.Count; i++)
            {
                if (i == order.Count - 1)
                    builder.Append($"{order[i].PizzaId}\n");
                else
                    builder.Append($"{order[i].PizzaId} ");
            }

            return builder.ToString();
        }
    }
}