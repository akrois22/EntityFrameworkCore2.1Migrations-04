using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace Festify.iOS
{
    static class Startup
    {
        public static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // Load the connection string.
            string connectionString = EnsureDatabaseExists();

            // Configure the DbContext.
            Festify.MobileRepository.Startup.ConfigureServices(serviceCollection, connectionString);
        }










        private static string EnsureDatabaseExists()
        {
            string applicationDirectory = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "Festify");
            if (!Directory.Exists(applicationDirectory))
            {
                Directory.CreateDirectory(applicationDirectory);
            }

            string databaseFile = Path.Combine(
                applicationDirectory,
                "Festify.db3");
            if (!File.Exists(databaseFile))
            {
                File.Copy(Path.Combine(
                    Environment.CurrentDirectory,
                    "Festify.db3"), databaseFile);
            }
            string connectionString = $"Data Source={databaseFile}";
            return connectionString;
        }
    }
}