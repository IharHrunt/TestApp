using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Mocking
{
    public class Programm
    {
        public static void Main()
        {
            var videoservice = new VideoService();
            videoservice.ReadVideoTitle();
        }
    }
}
