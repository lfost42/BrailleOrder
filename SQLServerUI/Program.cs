using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using BrailleSortLibrary;
using BrailleSortLibrary.Models;

namespace SQLServerUI
{
    class Program
    {
        static void Main(string[] args)
        {
            UserControl sql = new UserControl(GetConnectionString());
            
            ReadAllUsers(sql);

            //Console.WriteLine(GetConnectionString());
            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        private static void ReadAllUsers(UserControl sql)
        {
            var rows = sql.GetAllUsers();

            foreach (var row in rows)
            {
               Console.WriteLine($"{ row.Id }: { row.FirstName } { row.LastName}");
            }

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
