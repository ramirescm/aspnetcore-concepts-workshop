﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Lab4B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
		        .ConfigureAppConfiguration((builderContext, config) =>
                {
                    config.AddJsonFile("config.json");
                })
		        .UseStartup<Startup>();
    }
}
