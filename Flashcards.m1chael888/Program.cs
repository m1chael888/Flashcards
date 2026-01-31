using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Flashcards.m1chael888.Infrastructure;
using Flashcards.m1chael888.Controllers;
using Flashcards.m1chael888.Views;

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
            var connectionString = builder.GetConnectionString("ConnectionString");

            var collection = new ServiceCollection();

            collection.AddScoped<IDbInitializer>(x => new DbInitializer(connectionString));
            collection.AddScoped<IFlashcardsController, FlashcardsController>();
            collection.AddScoped<IMainMenuView, MainMenuView>();

            var provider = collection.BuildServiceProvider();

            var initializer = provider.GetRequiredService<IDbInitializer>();
            initializer.Initialize();

            var controller = provider.GetRequiredService<IFlashcardsController>();
            controller.HandleMainMenuOption();
        }
    } 
}