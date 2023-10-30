using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MegaDesk_ASP.NET_Core_Razor_Web_Application.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext") ?? throw new InvalidOperationException("Connection string 'MegaDesk_ASPNET_Core_Razor_Web_ApplicationContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
