using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Flashcards.m1chael888
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json")
                .Build();
            var connectionString = builder.GetConnectionString("source");

            var serviceCollection = new ServiceCollection();

            serviceCollection.Add
        }
    }
}