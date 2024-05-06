using AsyncTest.Application;
using AsyncTest.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace AsyncTest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                System.Windows.Forms.Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<Form1>();
        
            services.AddTransient<ISearchEngine, SearchEngine>();

            services.AddScoped<ICatalogRepo, CatalogRepo>();
        }
    }
}