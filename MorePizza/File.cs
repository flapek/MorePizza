using System;

namespace MorePizza
{
    public class File
    {
        private string path;

        public File(string path)
        {
            this.path = path;
        }

        public string[] ReadFile()
        {
            if (!System.IO.File.Exists(path))
                return null;

            using (System.IO.StreamReader stream = new System.IO.StreamReader(path))
            {
                string all = stream.ReadToEnd();
                string[] result = all.Split(new string[] { " ", "\n" }, StringSplitOptions.None);
                return result;
            }
        }
    }
}