using Blazor_WebAssembly.Services;
using BlazorApp1;
using Class_Library.Context;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<IProductsContext, ProductsContext>();
builder.Services.AddTransient<IProductsService, ProductsService>();
builder.Services.AddSingleton<ICartService, CartService>();

await builder.Build().RunAsync();