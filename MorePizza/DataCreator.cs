using System;
using System.Collections.Generic;
using System.Text;

namespace MorePizza
{
    public class DataCreator
    {
        public DataCreator()
        {
        }

        public static string CreateString(List<int> list)
        {
            StringBuilder builder = new StringBuilder();

            builder.Append($"{list.Count}\n");
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                    builder.Append($"{list[i]}\n");
                else
                    builder.Append($"{list[i]} ");
            }

            return builder.ToString();
        }
    }
}