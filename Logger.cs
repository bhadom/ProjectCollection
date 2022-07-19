//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Diagnostics;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Logging;
//using System.Threading.Tasks;
//using System.Threading;

//namespace ProjectCollection
//{
//    public class Logger : BackgroundService
//    {
//        private readonly ILogger<Logger> _logger;
//        public Logger(ILogger<Logger> logger)
//        {
//            _logger = logger;
//        }

//        public override Task StartAsync(CancellationToken cancellationToken)
//        {
//            return base.StartAsync(cancellationToken);
//        }

//        public override Task StopAsync(CancellationToken cancellationToken)
//        {
//            return base.StopAsync(cancellationToken);
//        }

//        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
//        {
//            while (!stoppingToken.IsCancellationRequested)
//            {
//                _logger.LogInformation("The program is still running");
//                await Task.Delay(60000, stoppingToken);
//            }
//        }
//        public void WriteError(string sb, Exception ex)
//        {
//            _logger.LogError(sb, ex);
//        }
//    }
//}
