using System;
using System.Collections.Generic;
using System.Linq;

namespace MorePizza
{
    class Program
    {
        static void Main()
        {
            string path1 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_example.in";
            string path1c = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_output.in";
            string path2 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\b_small.in";
            string path2c = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\b_output.in";
            string path3 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\c_medium.in";
            string path3c = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\c_output.in";
            string path4 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\d_quite_big.in";
            string path4c = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\d_output.in";
            string path5 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\e_also_big.in";
            string path5c = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\e_output.in";

            File file = new File();
            string[] list = file.ReadFile(path5);
            Order order = new Order(list);
            List<int> orderedPizza = order.GenerateOrder();
            string data = DataCreator.CreateString(orderedPizza);
            file.CreateFile(path5c, data);
        }
    }
}
