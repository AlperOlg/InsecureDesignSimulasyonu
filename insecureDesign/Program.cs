using DataAccessLayer.abstractt;
using DataAccessLayer.concrate;
using Microsoft.Extensions.DependencyInjection;

namespace insecureDesign
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

            ServiceCollection service = new();
            service.AddTransient<ucKayitOl>();
            service.AddTransient<ucGirisYap>();
            service.AddTransient<Form1>();
            service.AddDbContextFactory<InsecureDesignDbContext>();
            service.AddScoped<IUserDataAccess, UserDataAccess>();
            using (ServiceProvider serviceProvider = service.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<Form1>();
                Application.Run(mainForm);

            }
        }
    }
}