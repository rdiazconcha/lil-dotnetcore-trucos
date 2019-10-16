using System.IO;
using System.Threading.Tasks;

namespace usings
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var writer = new StreamWriter("archivo.txt", true);
            await writer.WriteLineAsync("Hola");
        }
    }
}