using ShoppingCartSystem.Cli;
using ShoppingCartSystem.Models;
using ShoppingCartSystem.Processors;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShoppingCartSystem.Processors.Interfaces;
using ShoppingCartSystem;

var builder = Host.CreateApplicationBuilder(args);
var services = builder.Services;

services.AddSingleton<IDiscountStrategy, DefaultDiscountStrategy>();
services.AddSingleton<IShippingCalculator, DefaultShippingCalculator>();
services.AddSingleton<IShoppingCart, ShoppingCart>();

services.AddSingleton<ShoppingCli>();

using var host = builder.Build();
host.Services.GetRequiredService<ShoppingCli>().Run();