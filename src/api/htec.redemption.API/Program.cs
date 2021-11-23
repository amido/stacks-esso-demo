﻿using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace htec.redemption.API
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(config =>
                {
                    var requiredConfig = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true";
                    config.AddJsonFile($"config/appsettings.json", optional: !requiredConfig, reloadOnChange: false);
                    config.AddEnvironmentVariables();
                })
                .ConfigureLogging((context, builder) =>
                {
                    Log.Logger = new LoggerConfiguration()
                           .ReadFrom.Configuration(context.Configuration)
                           .CreateLogger();
                })
                .UseStartup<Startup>()
                .UseSerilog()
                //.ConfigureServices(ConfigureStaticDependencies)
                //.ConfigureServices(ConfigureProductionDependencies)
            ;
    }
}
