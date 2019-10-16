using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var ports = PortsLibrary.Helper.GetAllPorts();
            foreach (var port in ports)
            {
                Console.WriteLine(port);
            }
        }
    }
}
