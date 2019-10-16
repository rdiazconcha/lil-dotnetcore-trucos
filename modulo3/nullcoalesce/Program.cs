using System.IO;
using System.Text;

namespace nullcoalesce
{
    class Program
    {
        static void Main(string[] args)
        {
           CreateFile();
        }

        static void CreateFile(StringBuilder sb = null, string fileName = null)
        {
            var countries = new string[] {
                "España",
                "México",
                "Argentina",
                "Colombia",
                "Perú"
            };

            sb ??= new StringBuilder();

            sb.AppendJoin(",", countries);

            using var writer =  new StreamWriter(fileName ?? "archivo.txt", true, Encoding.UTF8);
            writer.WriteLine(sb.ToString());
        }
    }
}