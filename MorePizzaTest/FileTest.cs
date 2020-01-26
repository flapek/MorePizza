using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;
using System.Collections.Generic;

namespace MorePizzaTest
{
    [TestClass]
    public class FileTest
    {
        private string path1 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_example.in";
        private string path2 = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_output.in";

        [TestMethod]
        public void TestReadFromFile()
        {
            File file = new File();
            string expected = "8";
            string[] list = file.ReadFile(path1);


            Assert.AreEqual(expected, list[5]);
        }

        [TestMethod]
        public void TestCreateFile()
        {
            File file = new File();
            string data = "3\n0 2 3\n";
            file.CreateFile(path2, data);

            Assert.IsTrue(System.IO.File.Exists(path2));
        }
    }
}
