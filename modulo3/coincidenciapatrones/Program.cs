using System;
using System.IO;
using System.Text;

namespace coincidenciapatrones
{
    public class Countries
    {
        public enum Continent 
        {
            America,
            Europe,
            Asia,
            Africa
        }
        string[] countries = null;
        public Countries()
        {
            countries ??= new string[] {
                "México",
                "España",
                "China",
                "Egipto"
            };
        }

        // public Continent GetContinent(string country)
        // {
        //     switch (country) 
        //     {
        //         case "México":
        //             return Continent.America;
        //         case "España":
        //             return Continent.Europe;
        //         case "Egipto":
        //             return Continent.Africa;
        //         case "China" :
        //             return Continent.Asia;
        //         default:
        //             throw new ArgumentException();
        //     }
        // }

        public Continent GetContinent(string country) =>
         country switch
         {
             "México" => Continent.America,
             "España" => Continent.Europe,
             "Egipto" => Continent.Africa,
             "China"  => Continent.Asia,
             _        => throw new ArgumentException()
         };

        public string[] GetAll()
        {
            return countries;
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

            Console.WriteLine(countries.GetContinent(countries.GetAll()[0]));

            sb.AppendJoin(",", countries.GetAll());

            using var writer =  new StreamWriter(fileName ?? "archivo.txt", true, Encoding.UTF8);
            writer.WriteLine(sb.ToString());
        }
    }
}
