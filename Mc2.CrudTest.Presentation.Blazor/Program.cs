using Mc2.CrudTest.Presentation.Blazor.Data;
using Mc2.CrudTest.Presentation.Infrustructure;
using Mc2.CrudTest.Presentation.Infrustructure.Repositories;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddDbContext<Mc2Context>(options => options.UseSqlServer("Server=192.168.1.101;User Id=sa;PWD=123;Database=Mc2DBTest;TrustServerCertificate=Yes;MultipleActiveResultSets=true"));
builder.Services.AddScoped<ICustomersRespository, CustomersRespository>();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
