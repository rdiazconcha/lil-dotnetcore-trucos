using System;
using System.IO;
using System.Text;

namespace funcionestaticas
{
    public class Countries
    {
        string[] countries = null;
        public Countries()
        {
            countries ??= new string[] {
                "México",
                "Colombia",
                "Perú",
                "Chile",
                "España",
                "Argentina",
                "Costa Rica",
                "Venezuela",
                "Brasil",
                "Panamá",
                "Uruguay"
            };
        }
        
        public string[] GetPacificAllianceCountries()
        {
            return Filter(countries);
            static string[] Filter(string[] countries) => countries[0..4];
        }
    }
     class Program
    {
        static void Main(string[] args)
        {
           CreateFile();
        }

        static void CreateFile(StringBuilder sb = null, string fileName = null)
        {
            sb ??= new StringBuilder();

            var countries = new Countries();

            sb.AppendJoin(",", countries.GetPacificAllianceCountries());

            using var writer =  new StreamWriter(fileName ?? "archivo.txt", true, Encoding.UTF8);
            writer.WriteLine(sb.ToString());
        }
    }
}
