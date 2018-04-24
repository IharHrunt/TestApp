using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Mocking
{
    public interface IFileReader
    {
        string Read(string path);
    }

    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            //return File.ReadAllText(path);
            return "";
        }
    }

    //public class FakeFileReader : IFileReader
    //{
    //    public string Read(string path)
    //    {
    //        return "";
    //    }
    //}

}
