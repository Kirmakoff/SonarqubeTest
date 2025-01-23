using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarqubeTest
{
    public class FakeServer
    {
        public void Initialize()
        {
            Console.WriteLine("Init");
        }

        public void DoStuff()
        {
            Console.WriteLine("Doing stuff");
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }
    }
}
