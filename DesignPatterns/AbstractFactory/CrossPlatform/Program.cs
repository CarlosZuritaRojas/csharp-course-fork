using CrossPlatform;
using CrossPlatform.Client;
using CrossPlatform.Interfaces;
using CrossPlatform.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);
var services = builder.Services;

// TODO: This service registration violates Dependency Inversion Principle (DIP)
// We're registering concrete classes instead of interfaces
// HINT: Create interfaces for all services and register them properly
services.AddSingleton<IUserInterfaceApplication, UserInterfaceApplication>();
services.AddSingleton<IUserInterfaceComponentFactory, LinuxUserInterfaceFactory>();
services.AddSingleton<UserInterfaceManager>();

// TODO: No other services are registered - violates proper DI setup
// The ReportGeneratorCli class will have to create all its dependencies
// HINT: Register all dependencies (parsers, generators, analyzers) here
using var host = builder.Build();

// Run the CLI application
host.Services.GetRequiredService<UserInterfaceManager>().Run(args);