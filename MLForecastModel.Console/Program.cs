using System;
using System.IO;

namespace MLForecastModel.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
        }

        private static string ConnectionString
        {
            get
            {
                string rootDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../"));
                string dbFilePath = Path.Combine(rootDir, "Data", "DailyDemand.mdf");
                string modelPath = Path.Combine(rootDir, "MLModel.zip");
                var connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True;Connect Timeout=30;";

                return connectionString;
            }
        }
    }
}
