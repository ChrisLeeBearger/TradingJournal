using TradingJournal.Application.DependencyInjection;
using TradingJournal.Infrastructure.Server.DependencyInjection;
using FluentValidation.AspNetCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// add json options to controller to ignore circular references when serializing
builder.Services.AddControllersWithViews().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); 

builder.Services.AddRazorPages();

// add fluent validation, used for client side validation of models
builder.Services.AddFluentValidation();

builder.Services.AddHttpContextAccessor();

// Add dependencies from Infrastructure library
builder.Services.AddServerInfrastructure(builder.Configuration);
// Add dependencies from Application library
builder.Services.AddServerApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

// enable authentication and authorization
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();