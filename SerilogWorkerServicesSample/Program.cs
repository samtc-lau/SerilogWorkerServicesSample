using Serilog;
using SerilogWorkerServicesSample;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<Worker>();
builder.Services.AddSerilog((serviceProvider, configuration) =>
{
    configuration.ReadFrom.Configuration(builder.Configuration);
});

var host = builder.Build();
host.Run();