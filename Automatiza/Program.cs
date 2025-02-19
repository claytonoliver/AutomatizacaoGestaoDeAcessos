

using Automatiza.Visual;
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

            var mainForm = serviceProvider.GetRequiredService<Form_Main>();

            Application.Run(new Form_Main());
            //Application.Run(new Frm_inicio());
        }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<Form_Main>();

            return services.BuildServiceProvider();
        }
    }
}