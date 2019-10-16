using System.IO;

namespace usings
{
    class Program
    {
        static void Main(string[] args)
        {
            using var writer = new StreamWriter("archivo.txt", true);
            writer.WriteLine("Hola");
        }
    }
}