using Microsoft.Extensions.DependencyInjection;

namespace Automatiza
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ConfigureServices();

            var mainForm = serviceProvider.GetRequiredService<Frm_inicio>();

            Application.Run(new Frm_inicio());
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<Frm_inicio>();

            return services.BuildServiceProvider();
        }
    }
}