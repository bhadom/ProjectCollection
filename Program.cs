using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProjectCollection.Logging;
using Serilog;
using System;
using System.Windows.Forms;
using ProjectCollection.TimeCalculator;
using ProjectCollection.MenuPlan;


namespace ProjectCollection
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ///Generate Host Builder and Register the Services for DI
            var builder = new HostBuilder()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddScoped<FrmMain>();
                   services.AddScoped<FrmClient>();
                   services.AddScoped<FrmMenuPlan>();
                   services.AddScoped<FrmCustomMenuPlan>();
                   services.AddScoped<ICreateMail, CreateMail>();
                   //services.AddScoped<ICreateLogging, FrmTimeCalculatorSimple>();
                   services.AddScoped<FrmTimeCalculatorComplete>();
                   services.AddScoped<ICreateLogging, CreateLogging>();
                   services.AddScoped<ICalculateSimpleTimes, CalculateTimes>();
                   services.AddScoped<ICalculateWorkHours, CalculateWorkHours>();
                   services.AddScoped<ICalculateCompleteTimes, CalculateCompleteTimes>();
                   services.AddScoped<Time>();

                   //Add Serilog
                   var serilogLogger = new LoggerConfiguration()
                   .WriteTo.File(@"..\..\..\Logs\Logs.log")
                   .CreateLogger();
                   services.AddLogging(x =>
                   {
                       x.SetMinimumLevel(LogLevel.Information);
                       x.AddSerilog(logger: serilogLogger, dispose: true);
                   });
                   
               });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form1 = services.GetRequiredService<FrmClient>();
                    //var form3 = services.GetRequiredService<FrmTimeCalculatorComplete>();
                    var form2 = services.GetRequiredService<FrmMain>();
                    Application.Run(form2);

                    
                    Console.WriteLine("Success");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error" + ex + " Occured");
                }
            }

            //Application.Run(new FrmClient());

            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Debug()
            //    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            //    .Enrich.FromLogContext()
            //    .WriteTo.File(@"..\..\..\Logs\Logs.log")
            //    .CreateLogger();


            //try
            //{
            //    Log.Information("Program is getting started");
            //    CreateHostBuilder(args).Build().Run();
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    Log.Fatal(ex, "Program crashed");
            //    return;
            //}
            //finally
            //{
            //    Log.CloseAndFlush();
            //}
        }

        //public static IHostBuilder CreateHostBuilder(string[] args)
        //{
        //    return Host.CreateDefaultBuilder(args).ConfigureServices((hostContext, services) =>
        //    { 
        //        services.AddHostedService<Logger>();
        //    }
        //)   .UseSerilog();
        //}
    }
}
