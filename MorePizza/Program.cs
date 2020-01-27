using System;
using System.Collections.Generic;
using System.Linq;

namespace MorePizza
{
    class Program
    {
        static void Main()
        {
            var pathsIn = new List<string>();
            pathsIn.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\ExampleData\a_example.in");
            pathsIn.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\ExampleData\b_small.in");
            pathsIn.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\ExampleData\c_medium.in");
            pathsIn.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\ExampleData\d_quite_big.in");
            pathsIn.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\ExampleData\e_also_big.in");

            var pathsOut = new List<string>();
            pathsOut.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\Output\a_example.out");
            pathsOut.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\Output\b_small.out");
            pathsOut.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\Output\c_medium.out");
            pathsOut.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\Output\d_quite_big.out");
            pathsOut.Add(@"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\Output\e_also_big.out");


            for (int i = 0; i < pathsIn.Count(); i++)
            {
                var file = new File();
                var orderList = file.ReadFile(pathsIn[i]);

                var order = new Order(orderList);
                var orders = order.GenerateOrder();

                string data = DataCreator.CreateString(orders);

                file.CreateFile(pathsOut[i], data);

                Console.WriteLine("Aktualny plik: " + pathsIn[i] + " - wynik: " + orders.Sum(x => x.SlicesOfPizza));
            }
        }
    }
}
