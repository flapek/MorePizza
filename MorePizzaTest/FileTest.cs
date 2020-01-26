using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorePizza;
using System.Collections.Generic;

namespace MorePizzaTest
{
    [TestClass]
    public class FileTest
    {
        private string pathToRead = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_example.in";
        private string pathToCreate = @"C:\Users\filap\source\repos\HashCode\MorePizza\MorePizza\File\a_output.in";

        /// <summary>
        /// Metoda sprawdza czy odpowiednio zosta³a utworzona tablica list z pliku
        /// </summary>
        [TestMethod]
        public void TestReadFromFile()
        {
            File file = new File();
            string expected = "8";
            string[] list = file.ReadFile(pathToRead);

            Assert.AreEqual(expected, list[5]);
        }

        /// <summary>
        /// Metoda spradza czy odpowiednio zosta³ utworzony plik wynikowy
        /// </summary>
        [TestMethod]
        public void TestCreateFile()
        {
            File file = new File();
            string data = "3\n0 2 3\n";
            file.CreateFile(pathToCreate, data);

            Assert.IsTrue(System.IO.File.Exists(pathToCreate));
        }
    }
}
