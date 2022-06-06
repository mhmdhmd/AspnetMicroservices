using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Cache.CacheManager;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json")
                            .Build();

//builder.Host.ConfigureLogging(loggingBuilder =>
//{
//    loggingBuilder.AddConfiguration(builder.Configuration.GetSection("Logging"));
//    loggingBuilder.AddConsole();
//    loggingBuilder.AddDebug();
//});

builder.Services.AddOcelot(configuration).AddCacheManager(x =>
{
    x.WithDictionaryHandle();
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

await app.UseOcelot();

app.Run();
