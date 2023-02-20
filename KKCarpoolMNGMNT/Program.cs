using KKCarpoolMNGMNT;
using KKCarpoolMNGMNT.Models;
using KKCarpoolMNGMNT.Services;
using Microsoft.AspNetCore;

/*var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();




app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();*/

    CreateWebHostBuilder(args).Build().Run();


static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    WebHost.CreateDefaultBuilder(args)
        .UseStartup<Startup>();
