using IOC.Service;
using IOC.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace IOC.Build_In
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IWalletRepository, WalletRepository>()
                .AddScoped<IWalletService, ConstructorInjectionWalletService>()
                .BuildServiceProvider();

            //configure log factory
            using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = loggerFactory.CreateLogger<Program>();


            //do the actual work here
            var walletService = serviceProvider.GetService<IWalletService>();

            double balance = 0;

            walletService.IncreaseAmount(1000);
            logger.LogInformation("Increase $1000");

            balance = walletService.GetBalance();
            logger.LogInformation($"Balance is: ${balance}");

            walletService.DecreaseAmount(500);
            logger.LogInformation($"Decrease $500");

            balance = walletService.GetBalance();
            logger.LogInformation($"Balance is: ${balance}");

            Console.ReadKey();
        }
    }
}
