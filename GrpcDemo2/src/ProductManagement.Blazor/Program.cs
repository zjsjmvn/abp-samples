using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace ProductManagement.Blazor;

public class Program
{
    public async static Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        var application = await builder.AddApplicationAsync<ProductManagementBlazorModule>(options =>
        {
            options.UseAutofac();
        });

        var host = builder.Build();

        try
        {
            await application.InitializeApplicationAsync(host.Services);

            await host.RunAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
