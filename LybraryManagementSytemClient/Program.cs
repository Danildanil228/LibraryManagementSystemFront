using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using LybraryManagementSytemClient.Services;
using LybraryManagementSytemClient;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// ��������� ������� ����� ��� HttpClient
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5000") });

// ������������ GraphQLService
builder.Services.AddScoped<GraphQLService>();

await builder.Build().RunAsync();