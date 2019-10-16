using System;
using System.IO;
using System.Text;

namespace indices_rangos
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
                "España", //0
                "México",  //1
                "Argentina", //2
                "Colombia", //3
                "Perú", //4
                "Costa Rica", //5
                "Venezuela", //6
                "Brasil", //7
                "Panamá", //8
                "Uruguay" //9
            };

            sb ??= new StringBuilder();

            sb.AppendJoin(",", countries[^1]);

            using var writer =  new StreamWriter(fileName ?? "archivo.txt", true, Encoding.UTF8);
            writer.WriteLine(sb.ToString());
        }
    }
}