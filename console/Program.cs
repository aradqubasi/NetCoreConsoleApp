using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;

namespace console
{
    class Program
    {
        private static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();
            
            var config = LoadConfiguration();
            services.AddSingleton(config);

            services.AddTransient<ITestService, TestService>();

            services.AddTransient<ConsoleApplication>();

            services.AddLogging(logging => 
            {
                logging.AddConfiguration(config.GetSection("Logging"));
                logging.AddConsole();
            });

            return services;
        }

        private static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return builder.Build();
        }

        static void Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<ConsoleApplication>().Run();
        }
    }
}
