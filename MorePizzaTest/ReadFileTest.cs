using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;

namespace MorePizzaTest
{
    [TestClass]
    public class ReadFileTest
    {
        private string path = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_example.in";

        [TestMethod]
        public void TestReadFromFile()
        {
            File file = new File(path);
            string expected = "8";
            string[] list = file.ReadFile();


            Assert.AreEqual(expected, list[5]);
        }
    }
}
