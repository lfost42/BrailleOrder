using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace SQLServerUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        private static string GetConnectionString(string connectionStringName = "Default")
        {
            string output = "";
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            var config = builder.Build();

            output = config.GetConnectionString(connectionStringName);

            return output;
        }
    }
}
