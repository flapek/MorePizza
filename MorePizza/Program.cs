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
            string path2 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\b_small.in";
            string path3 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\c_medium.in";
            string path4 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\d_quite_big.in";
            string path5 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\e_also_big.in";

            File file = new File(path5);
            string[] list = file.ReadFile();
            Order order = new Order(list);
            List<int> orderedPizza = order.GenerateOrder();
            //foreach (var item in orderedPizza)
            //{
            //    Console.WriteLine(item);
            //}
            
            var sum1 = order.MaximumSlice;
            var sum2 = orderedPizza.Sum();
            Console.WriteLine(sum1);
            Console.WriteLine($"Sum: {sum2}");
            Console.WriteLine($"Odd: {sum1 - sum2}");
            //Console.ReadLine();
        }
    }
}
