using DependencyMapping.Client;
using DependencyMapping.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorPanzoom;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorPanzoomServices();

//don't know if i need the mouseService. But it may come in handy when implementing the zoom capability
builder.Services
    .AddSingleton<MouseService>()
    .AddSingleton<IMouseService>(ff => ff.GetRequiredService<MouseService>());

await builder.Build().RunAsync();
