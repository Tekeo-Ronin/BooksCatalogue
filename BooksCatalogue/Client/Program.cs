using BooksCatalogue.Client;
using BooksCatalogue.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:5000") // Замініть на URL вашого API
});

builder.Services.AddScoped<IBookService, BookService>();


await builder.Build().RunAsync();
